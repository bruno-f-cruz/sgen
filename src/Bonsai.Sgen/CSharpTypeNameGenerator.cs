using NJsonSchema;

namespace Bonsai.Sgen
{
    internal class CSharpTypeNameGenerator : DefaultTypeNameGenerator
    {
        public bool SkipExternalTypeNames { get; set; }

        protected override string Generate(JsonSchema schema, string typeNameHint)
        {
            var defaultName = base.Generate(schema, typeNameHint);
            return CSharpNamingConvention.Instance.Apply(defaultName);
        }

        public override string Generate(JsonSchema schema, string typeNameHint, IEnumerable<string> reservedTypeNames)
        {
            if (!SkipExternalTypeNames && schema.TryGetExternalTypeName(out string typeName))
                return typeName;

            return base.Generate(schema, typeNameHint, reservedTypeNames);
        }

        public string GenerateNamespace(JsonSchema schema, string namespaceNameHint)
        {
            const char NamespaceSeparator = '.';
            var parts = namespaceNameHint.Split(NamespaceSeparator, StringSplitOptions.RemoveEmptyEntries);
            var partIdentifiers = Array.ConvertAll(parts, part => Generate(schema, part));
            return string.Join(NamespaceSeparator, partIdentifiers);
        }
    }
}
