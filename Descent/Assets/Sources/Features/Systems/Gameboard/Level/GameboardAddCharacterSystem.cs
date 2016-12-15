using Entitas;
using Descent.Helper.MetaData;
using Descent.Helper;
using System.Collections.Generic;

// Created: 20/11/2016 ~ Alexander Hunt.

/// <summary>
/// Gameboard Add Character System.
/// </summary>
public class GameboardAddCharacterSystem : IExecuteSystem, ISetPool
{
    /// <summary>
    /// Gameboard Pool.
    /// </summary>
    Pool _pool;

    /// <summary>
    /// Occurrence Component(s).
    /// </summary>
    List<OccurrenceComponent> _OccurrenceList = new List<OccurrenceComponent>();

    /// <summary>
    /// Spawn Point(s).
    /// </summary>
    List<Entity> _SpawnPoint = new List<Entity>();

    /// <summary>
    /// Spawn Point(s) Used.
    /// </summary>
    List<Entity> _SpawnPointUsed = new List<Entity>();

    /// <summary>
    /// Constructor.
    /// </summary>
    public GameboardAddCharacterSystem()
    {
        /* Register OnOccurrence Callback. */
        Occurrence.OnOccurrence += OnOccurrence;
    }

    /// <summary>
    /// Deconstructor.
    /// </summary>
    ~GameboardAddCharacterSystem()
    {
        /* Remove OnOccurrence Callback. */
        Occurrence.OnOccurrence -= OnOccurrence;
    }

    /// <summary>
    /// Set Pool Method.
    /// </summary>
    /// <param name="pool">Pool.</param>
    public void SetPool(Pool pool)
    {
        /* Cache Pool. */
        _pool = pool;

        /* Catch Entity(s) With GameboardElement Component. */
        _pool.GetGroup(GameboardMatcher.GameboardElement).OnEntityAdded += OnEntityAdded;
        _pool.GetGroup(GameboardMatcher.GameboardElement).OnEntityRemoved += OnEntityRemoved;
    }

    private void OnEntityRemoved(Group group, Entity entity, int index, IComponent component)
    {
        /* Remove Spawn Point. */
        _SpawnPointUsed.Remove(entity);
        _SpawnPoint.Remove(entity);
    }

    private void OnEntityAdded(Group group, Entity entity, int index, IComponent component)
    {
        /* Cache Component. */
        var GameboardElement = entity.gameboardElement;

        /* Occurrence Type Validation. */
        if (GameboardElement.Type == "Tile" &&
            GameboardElement.Subtype == "Spawn")
        {
            /* Cache Spawn Point. */
            _SpawnPoint.Add(entity);
        }
    }

    /// <summary>
    /// OnOccurrence Callback Method.
    /// </summary>
    /// <param name="Component">Component.</param>
    private void OnOccurrence(OccurrenceComponent Component)
    {
        /* Occurrence Type Validation. */
        if (Component.Type == OccurrenceType.Level.AddCharacter)
        {
            /* Cache Occurrence Component. */
            _OccurrenceList.Add(Component);
        }
    }

    /// <summary>
    /// System Execute Method.
    /// </summary>
    public void Execute()
    {
        /* AddCharacter Occurrence(s) Available? */
        if (_OccurrenceList.Count > 0)
        {
            /* Loop AddCharacter Occurrence(s). */
            foreach (var _Occurrence in _OccurrenceList)
            {
                /* Retrieve Character Occurrence Information. */
                string CharacterName = (string)_Occurrence.Args[0];
                int AvatarIndex = (int)_Occurrence.Args[1];
                int MovementCost = (int)_Occurrence.Args[2];
                int SpawnIndex = (int)_Occurrence.Args[3];
                
                /* Spawn Point(s) Available? */
                if (_SpawnPointUsed.Count < _SpawnPoint.Count)
                {
                    /* Get Spawn Point Entity. */
                    var Entity = _SpawnPoint[(SpawnIndex == -1) ? _SpawnPointUsed.Count: SpawnIndex];

                    /* Spawn Point Not Used? */
                    if (!_SpawnPointUsed.Contains(Entity))
                    {
                        /* Create Character. */
                        _pool.CreateEntity()
                            /* Add Positon Component. */
                            .AddPosition(Entity.position.X, Entity.position.Y, -1)
                            /* Add Gameboard Element Component. */
                            .AddGameboardElement("Player", CharacterName)
                            /* Give Character Movement Cost. */
                            .AddMovementCost(MovementCost)
                            /* Make Character Selectable. */
                            .IsSelectable(true)
                            /* Add Asset Component. */
                            .AddAsset("Player_" + AvatarIndex);

                        /* Spawn Point Used. */
                        _SpawnPointUsed.Add(Entity);

                        /* Create Character Added Signal. */
                        Occurrence.Level.Signal.CreateCharacterAddedSignal(this,
                            new CharacterInfo(CharacterName, AvatarIndex,
                            new SpawnInfo(SpawnIndex, Entity)));
                    }
                }
            }

            /* Cleanup Component(s). */
            _OccurrenceList.Clear();
        }
    }
}