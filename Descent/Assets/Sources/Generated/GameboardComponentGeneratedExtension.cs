//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public GameboardComponent gameboard { get { return (GameboardComponent)GetComponent(GameboardComponentIds.Gameboard); } }
        public bool hasGameboard { get { return HasComponent(GameboardComponentIds.Gameboard); } }

        public Entity AddGameboard(Entitas.Entity newSelectedUnit) {
            var component = CreateComponent<GameboardComponent>(GameboardComponentIds.Gameboard);
            component.SelectedUnit = newSelectedUnit;
            return AddComponent(GameboardComponentIds.Gameboard, component);
        }

        public Entity ReplaceGameboard(Entitas.Entity newSelectedUnit) {
            var component = CreateComponent<GameboardComponent>(GameboardComponentIds.Gameboard);
            component.SelectedUnit = newSelectedUnit;
            ReplaceComponent(GameboardComponentIds.Gameboard, component);
            return this;
        }

        public Entity RemoveGameboard() {
            return RemoveComponent(GameboardComponentIds.Gameboard);
        }
    }

    public partial class Pool {

        public Entity gameboardEntity { get { return GetGroup(GameboardMatcher.Gameboard).GetSingleEntity(); } }
        public GameboardComponent gameboard { get { return gameboardEntity.gameboard; } }
        public bool hasGameboard { get { return gameboardEntity != null; } }

        public Entity SetGameboard(Entitas.Entity newSelectedUnit) {
            if(hasGameboard) {
                throw new EntitasException("Could not set gameboard!\n" + this + " already has an entity with GameboardComponent!",
                    "You should check if the pool already has a gameboardEntity before setting it or use pool.ReplaceGameboard().");
            }
            var entity = CreateEntity();
            entity.AddGameboard(newSelectedUnit);
            return entity;
        }

        public Entity ReplaceGameboard(Entitas.Entity newSelectedUnit) {
            var entity = gameboardEntity;
            if(entity == null) {
                entity = SetGameboard(newSelectedUnit);
            } else {
                entity.ReplaceGameboard(newSelectedUnit);
            }

            return entity;
        }

        public void RemoveGameboard() {
            DestroyEntity(gameboardEntity);
        }
    }
}

    public partial class GameboardMatcher {

        static IMatcher _matcherGameboard;

        public static IMatcher Gameboard {
            get {
                if(_matcherGameboard == null) {
                    var matcher = (Matcher)Matcher.AllOf(GameboardComponentIds.Gameboard);
                    matcher.componentNames = GameboardComponentIds.componentNames;
                    _matcherGameboard = matcher;
                }

                return _matcherGameboard;
            }
        }
    }