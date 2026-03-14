using NJsonSchema;

namespace Bonsai.Sgen.Tests
{
    static class TestHelper
    {
        public static CSharpCodeDomGenerator CreateGenerator(
            JsonSchema schema,
            SerializerLibraries serializerLibraries = SerializerLibraries.YamlDotNet | SerializerLibraries.NewtonsoftJson,
            string schemaNamespace = nameof(TestHelper),
            bool skipExternalTypeNames = false)
        {
            var settings = new CSharpCodeDomGeneratorSettings
            {
                Namespace = schemaNamespace,
                SerializerLibraries = serializerLibraries,
                SkipExternalTypeNames = skipExternalTypeNames
            };
            schema = schema.WithCompatibleDefinitions(settings.TypeNameGenerator)
                           .WithResolvedAnyOfNullableProperty()
                           .WithResolvedDiscriminatorInheritance();

            return new CSharpCodeDomGenerator(schema, settings);
        }
    }
}
