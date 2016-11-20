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

        public OccurrenceComponent occurrence { get { return (OccurrenceComponent)GetComponent(OccurrenceComponentIds.Occurrence); } }
        public bool hasOccurrence { get { return HasComponent(OccurrenceComponentIds.Occurrence); } }

        public Entity AddOccurrence(int newLayer, string newType, object[] newArgs) {
            var component = CreateComponent<OccurrenceComponent>(OccurrenceComponentIds.Occurrence);
            component.Layer = newLayer;
            component.Type = newType;
            component.Args = newArgs;
            return AddComponent(OccurrenceComponentIds.Occurrence, component);
        }

        public Entity ReplaceOccurrence(int newLayer, string newType, object[] newArgs) {
            var component = CreateComponent<OccurrenceComponent>(OccurrenceComponentIds.Occurrence);
            component.Layer = newLayer;
            component.Type = newType;
            component.Args = newArgs;
            ReplaceComponent(OccurrenceComponentIds.Occurrence, component);
            return this;
        }

        public Entity RemoveOccurrence() {
            return RemoveComponent(OccurrenceComponentIds.Occurrence);
        }
    }
}

    public partial class OccurrenceMatcher {

        static IMatcher _matcherOccurrence;

        public static IMatcher Occurrence {
            get {
                if(_matcherOccurrence == null) {
                    var matcher = (Matcher)Matcher.AllOf(OccurrenceComponentIds.Occurrence);
                    matcher.componentNames = OccurrenceComponentIds.componentNames;
                    _matcherOccurrence = matcher;
                }

                return _matcherOccurrence;
            }
        }
    }
