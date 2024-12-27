//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace PersonAndDog
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (YamlDotNet v13.0.0.0)")]
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class Person
    {
    
        private int _age;
    
        private string _firstName;
    
        private string _lastName;
    
        private System.DateTimeOffset _dOB;
    
        public Person()
        {
        }
    
        protected Person(Person other)
        {
            _age = other._age;
            _firstName = other._firstName;
            _lastName = other._lastName;
            _dOB = other._dOB;
        }
    
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="Age")]
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="FirstName")]
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
    
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="LastName")]
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="DOB")]
        public System.DateTimeOffset DOB
        {
            get
            {
                return _dOB;
            }
            set
            {
                _dOB = value;
            }
        }
    
        public System.IObservable<Person> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(new Person(this)));
        }
    
        public System.IObservable<Person> Process<TSource>(System.IObservable<TSource> source)
        {
            return System.Reactive.Linq.Observable.Select(source, _ => new Person(this));
        }
    
        protected virtual bool PrintMembers(System.Text.StringBuilder stringBuilder)
        {
            stringBuilder.Append("Age = " + _age + ", ");
            stringBuilder.Append("FirstName = " + _firstName + ", ");
            stringBuilder.Append("LastName = " + _lastName + ", ");
            stringBuilder.Append("DOB = " + _dOB);
            return true;
        }
    
        public override string ToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append(GetType().Name);
            stringBuilder.Append(" { ");
            if (PrintMembers(stringBuilder))
            {
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (YamlDotNet v13.0.0.0)")]
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class Dog
    {
    
        private string _name;
    
        private string _breed;
    
        private int _age;
    
        public Dog()
        {
        }
    
        protected Dog(Dog other)
        {
            _name = other._name;
            _breed = other._breed;
            _age = other._age;
        }
    
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="Name")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="Breed")]
        public string Breed
        {
            get
            {
                return _breed;
            }
            set
            {
                _breed = value;
            }
        }
    
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="Age")]
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    
        public System.IObservable<Dog> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(new Dog(this)));
        }
    
        public System.IObservable<Dog> Process<TSource>(System.IObservable<TSource> source)
        {
            return System.Reactive.Linq.Observable.Select(source, _ => new Dog(this));
        }
    
        protected virtual bool PrintMembers(System.Text.StringBuilder stringBuilder)
        {
            stringBuilder.Append("Name = " + _name + ", ");
            stringBuilder.Append("Breed = " + _breed + ", ");
            stringBuilder.Append("Age = " + _age);
            return true;
        }
    
        public override string ToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append(GetType().Name);
            stringBuilder.Append(" { ");
            if (PrintMembers(stringBuilder))
            {
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (YamlDotNet v13.0.0.0)")]
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class PersonAndPet
    {
    
        private Person _owner;
    
        private Dog _pet;
    
        public PersonAndPet()
        {
        }
    
        protected PersonAndPet(PersonAndPet other)
        {
            _owner = other._owner;
            _pet = other._pet;
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="owner")]
        public Person Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="pet")]
        public Dog Pet
        {
            get
            {
                return _pet;
            }
            set
            {
                _pet = value;
            }
        }
    
        public System.IObservable<PersonAndPet> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(new PersonAndPet(this)));
        }
    
        public System.IObservable<PersonAndPet> Process<TSource>(System.IObservable<TSource> source)
        {
            return System.Reactive.Linq.Observable.Select(source, _ => new PersonAndPet(this));
        }
    
        protected virtual bool PrintMembers(System.Text.StringBuilder stringBuilder)
        {
            stringBuilder.Append("owner = " + _owner + ", ");
            stringBuilder.Append("pet = " + _pet);
            return true;
        }
    
        public override string ToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append(GetType().Name);
            stringBuilder.Append(" { ");
            if (PrintMembers(stringBuilder))
            {
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }


    /// <summary>
    /// Serializes a sequence of data model objects into YAML strings.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (YamlDotNet v13.0.0.0)")]
    [System.ComponentModel.DescriptionAttribute("Serializes a sequence of data model objects into YAML strings.")]
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    public partial class SerializeToYaml
    {
    
        private System.IObservable<string> Process<T>(System.IObservable<T> source)
        {
            return System.Reactive.Linq.Observable.Defer(() =>
            {
                var serializer = new YamlDotNet.Serialization.SerializerBuilder()
                    .Build();
                return System.Reactive.Linq.Observable.Select(source, value => serializer.Serialize(value)); 
            });
        }

        public System.IObservable<string> Process(System.IObservable<Person> source)
        {
            return Process<Person>(source);
        }

        public System.IObservable<string> Process(System.IObservable<Dog> source)
        {
            return Process<Dog>(source);
        }

        public System.IObservable<string> Process(System.IObservable<PersonAndPet> source)
        {
            return Process<PersonAndPet>(source);
        }
    }


    /// <summary>
    /// Deserializes a sequence of YAML strings into data model objects.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (YamlDotNet v13.0.0.0)")]
    [System.ComponentModel.DescriptionAttribute("Deserializes a sequence of YAML strings into data model objects.")]
    [System.ComponentModel.DefaultPropertyAttribute("Type")]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<Person>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<Dog>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<PersonAndPet>))]
    public partial class DeserializeFromYaml : Bonsai.Expressions.SingleArgumentExpressionBuilder
    {
    
        public DeserializeFromYaml()
        {
            Type = new Bonsai.Expressions.TypeMapping<PersonAndPet>();
        }

        public Bonsai.Expressions.TypeMapping Type { get; set; }

        public override System.Linq.Expressions.Expression Build(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments)
        {
            var typeMapping = (Bonsai.Expressions.TypeMapping)Type;
            var returnType = typeMapping.GetType().GetGenericArguments()[0];
            return System.Linq.Expressions.Expression.Call(
                typeof(DeserializeFromYaml),
                "Process",
                new System.Type[] { returnType },
                System.Linq.Enumerable.Single(arguments));
        }

        private static System.IObservable<T> Process<T>(System.IObservable<string> source)
        {
            return System.Reactive.Linq.Observable.Defer(() =>
            {
                var serializer = new YamlDotNet.Serialization.DeserializerBuilder()
                    .Build();
                return System.Reactive.Linq.Observable.Select(source, value =>
                {
                    var reader = new System.IO.StringReader(value);
                    var parser = new YamlDotNet.Core.MergingParser(new YamlDotNet.Core.Parser(reader));
                    return serializer.Deserialize<T>(parser);
                });
            });
        }
    }
}