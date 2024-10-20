namespace DND5eAPI.Models.Structures.Effects
{
    public class EffectComparer : IEqualityComparer<Effect>
    {
        public bool Equals(Effect? x, Effect? y)
        {
            if (ReferenceEquals(x, y))
                return true;

            if (x == null || y == null)
                return false;

            if (x.EffectType != y.EffectType)
                return false;

            if (x is ResistanceEffect rx && y is ResistanceEffect ry)
            {
                return rx.DamageType == ry.DamageType &&
                       rx.IsVulnerable == ry.IsVulnerable &&
                       rx.IsResistant == ry.IsResistant &&
                       rx.IsImmune == ry.IsImmune;
            }
            throw new InvalidOperationException("Unknown effect type encountered");
        }

        public int GetHashCode(Effect obj)
        {
            if (obj == null)
                return 0;

            int hashCode = obj.EffectType.GetHashCode();
            if (obj is ResistanceEffect rx)
            {
                hashCode = HashCode.Combine(hashCode, rx.DamageType?.GetHashCode() ?? 0);
                hashCode = HashCode.Combine(hashCode, rx.IsVulnerable);
                hashCode = HashCode.Combine(hashCode, rx.IsResistant);
                hashCode = HashCode.Combine(hashCode, rx.IsImmune);
            }
            return hashCode;
        }
    }

    public class EffectCollectionComparer : IEqualityComparer<ICollection<Effect>>
    {
        private readonly EffectComparer _effectComparer = new();

        public bool Equals(ICollection<Effect>? x, ICollection<Effect>? y)
        {
            if (ReferenceEquals(x, y))
                return true;

            if (x == null || y == null)
                return false;

            if (x.Count != y.Count)
                return false;

            return x.All(ex => y.Contains(ex, _effectComparer)) && y.All(ey => x.Contains(ey, _effectComparer));
        }

        public int GetHashCode(ICollection<Effect> obj)
        {
            if (obj == null)
                return 0;

            int hashCode = 0;
            foreach (var effect in obj)
            {
                hashCode = HashCode.Combine(hashCode, _effectComparer.GetHashCode(effect));
            }
            return hashCode;
        }
    }
}
