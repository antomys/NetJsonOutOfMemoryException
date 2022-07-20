// See https://aka.ms/new-console-template for more information

using Bogus;
using NetJsonOutOfMemory;

Faker<TestModel> TestModelFaker = new();

var testModels = TestModelFaker
    .RuleFor(testModel => testModel.TestByte, fakerSetter => fakerSetter.Random.Byte())
    .RuleFor(testModel => testModel.TestChar, fakerSetter => fakerSetter.Random.Char('a', 'z'))
    .RuleFor(testModel => testModel.TestDate, fakerSetter => fakerSetter.Date.Past().ToUniversalTime())
    .RuleFor(testModel => testModel.TestDouble, fakerSetter => fakerSetter.Random.Double())
    .RuleFor(testModel => testModel.TestFloat, fakerSetter => fakerSetter.Random.Float())
    .RuleFor(testModel => testModel.TestInt, fakerSetter => fakerSetter.Random.Int())
    .RuleFor(testModel => testModel.TestLong, fakerSetter => fakerSetter.Random.Long())
    .RuleFor(testModel => testModel.TestShort, fakerSetter => fakerSetter.Random.Short())
    .RuleFor(testModel => testModel.TestString, fakerSetter => fakerSetter.Random.String2(5, 10))
    .RuleFor(testModel => testModel.TestUInt, fakerSetter => fakerSetter.Random.UInt())
    .RuleFor(testModel => testModel.TestUShort, fakerSetter => fakerSetter.Random.UShort())
    .RuleFor(testModel => testModel.TestULong, fakerSetter => fakerSetter.Random.ULong())
    .RuleFor(testModel => testModel.TestTimeSpan, fakerSetter => fakerSetter.Date.Timespan())
    // .RuleFor(testModel => testModel.TestByteArray, fakerSetter => fakerSetter.Random.Bytes(internalCount))
    .RuleFor(testModel => testModel.TestCharArray, fakerSetter => fakerSetter.Random.Chars('a', 'z', count: 10))
    .RuleFor(testModel => testModel.TestDoubleArray, fakerSetter => fakerSetter.GetArray(func => func.Random.Double(), 10))
    .RuleFor(testModel => testModel.TestFloatArray, fakerSetter => fakerSetter.GetArray(func => func.Random.Float(), 10))
    .RuleFor(testModel => testModel.TestIntArray, fakerSetter => fakerSetter.GetArray(func => func.Random.Int(), 10))
    .RuleFor(testModel => testModel.TestUIntArray, fakerSetter => fakerSetter.GetArray(func => func.Random.UInt(), 10))
    .RuleFor(testModel => testModel.TestLongArray, fakerSetter => fakerSetter.GetArray(func => func.Random.Long(), 10))
    .RuleFor(testModel => testModel.TestShortArray, fakerSetter => fakerSetter.GetArray(func => func.Random.Short(), 10))
    .RuleFor(testModel => testModel.TestStringArray, fakerSetter => fakerSetter.GetArray(func => func.Random.String2(5, 10), 10))
    .RuleFor(testModel => testModel.TestUShortArray, fakerSetter => fakerSetter.GetArray(func => func.Random.UShort(), 10))
    .RuleFor(testModel => testModel.TestULongArray, fakerSetter => fakerSetter.GetArray(func => func.Random.ULong(), 10))
    .Generate(10)
    .ToArray();
    
NetJSON.NetJSONSettings netJsonOptions = new()
{
    DateFormat = NetJSON.NetJSONDateFormat.ISO,
    TimeZoneFormat = NetJSON.NetJSONTimeZoneFormat.Utc,
    CaseSensitive = false
};

var actualString =  NetJSON.NetJSON.Serialize(testModels, netJsonOptions);
//todo: cope with System.OutOfMemoryException: Array dimensions exceeded supported range.
var actualModels = NetJSON.NetJSON.Deserialize<TestModel[]>(actualString, netJsonOptions);

Console.ReadKey();