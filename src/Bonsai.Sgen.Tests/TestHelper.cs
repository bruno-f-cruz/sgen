using NJsonSchema;

namespace Bonsai.Sgen.Tests
{
    static class TestHelper
    {
        public static CSharpCodeDomGenerator CreateGenerator(
            JsonSchema schema,
            SerializerLibraries serializerLibraries = SerializerLibraries.YamlDotNet | SerializerLibraries.NewtonsoftJson,
            string schemaNamespace = nameof(TestHelper),
            bool generateExternalTypes = false)
        {
            var settings = new CSharpCodeDomGeneratorSettings
            {
                Namespace = schemaNamespace,
                SerializerLibraries = serializerLibraries
            };
            var nameGenerator = (CSharpTypeNameGenerator)settings.TypeNameGenerator;
            nameGenerator.GenerateExternalTypes = generateExternalTypes;
            schema = schema.WithCompatibleDefinitions(nameGenerator)
                           .WithResolvedAnyOfNullableProperty()
                           .WithResolvedDiscriminatorInheritance();

            return new CSharpCodeDomGenerator(schema, settings);
        }
    }
}
