using FluentNHibernate.MappingModel;

namespace FluentNHibernate.BackwardCompatibility
{
    public class PropertyMap
    {
        private readonly PropertyMapping _mapping;

        public PropertyMap(PropertyMapping mapping)
        {
            _mapping = mapping;
        }

        public PropertyMap WithLengthOf(int length)
        {
            _mapping.Length = length;
            return this;
        }

        public PropertyMap CanNotBeNull()
        {
            _mapping.AllowNull = false;
            return this;
        }
    }
}