# Serializer Generator Tool

`Bonsai.Sgen` is a code generator tool for the [Bonsai](https://bonsai-rx.org/) programming language. It leverages [JSON Schema](https://json-schema.org/) as a standard to specify [record data types](https://en.wikipedia.org/wiki/Record_(computer_science)), and automatically generates operators to create and manipulate these objects. It builds on top of  [NJsonSchema](https://github.com/RicoSuter/NJsonSchema) by providing further customization of the generated code as well as Bonsai-specific features.

## Getting Started

1. Navigate to the [Bonsai.Sgen NuGet tool package](https://www.nuget.org/packages/Bonsai.Sgen/)
2. Click `.NET CLI (Local)` and copy the two suggested commands. E.g.:

    ```cmd
    dotnet new tool-manifest # if you are setting up this repo
    dotnet tool install --local Bonsai.Sgen
    ```

3. To view the tool help reference documentation, run:

    ```cmd
    dotnet bonsai.sgen --help
    ```

4. To generate YAML serialization classes from a schema file:

    ```cmd
    dotnet bonsai.sgen --schema schema.json --serializer YamlDotNet
    ```

5. To generate JSON serialization classes from a schema file:

    ```cmd
    dotnet bonsai.sgen --schema schema.json --serializer NewtonsoftJson
    ```

6. Copy the generated class file to your project `Extensions` folder.

7. Add the necessary package references to your `Extensions.csproj` file. For example:

    ```xml
    <ItemGroup>
      <PackageReference Include="Bonsai.Core" Version="2.8.5" />
      <PackageReference Include="YamlDotNet" Version="13.7.1" />
    </ItemGroup>
    ```

8. To restore the tool at any point, run:

    ```cmd
    dotnet tool restore
    ```
