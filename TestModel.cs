namespace NetJsonOutOfMemory;

using System.Runtime.Serialization;

/// <summary>
///     Test model.
/// </summary>
public class TestModel
{
    /// <summary>
    ///     Gets or sets test string value.
    /// </summary>
    [DataMember(Name = "testString")]
    public virtual string TestString { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets test string array values.
    /// </summary>
    [DataMember(Name = "testStringArray")]
    public virtual string[] TestStringArray { get; set; }  = Array.Empty<string>();
    
    /// <summary>
    ///     Gets or sets test int value.
    /// </summary>
    [DataMember(Name = "testInt")]
    public virtual int TestInt { get; set; }
    
    /// <summary>
    ///     Gets or sets test int array values.
    /// </summary>
    [DataMember(Name = "testIntArray")]
    public virtual int[] TestIntArray { get; set; } = Array.Empty<int>();

    /// <summary>
    ///     Gets or sets test double value.
    /// </summary>
    [DataMember(Name = "testDouble")]
    public virtual double TestDouble { get; set; }
    
    /// <summary>
    ///     Gets or sets test double array values.
    /// </summary>
    [DataMember(Name = "testDoubleArray")]
    public virtual double[] TestDoubleArray { get; set; } = Array.Empty<double>();
    
    /// <summary>
    ///     Gets or sets test float value.
    /// </summary>
    [DataMember(Name = "testFloat")]
    public virtual float TestFloat { get; set; }
    
    /// <summary>
    ///     Gets or sets test float array values.
    /// </summary>
    [DataMember(Name = "testFloatArray")]
    public virtual float[] TestFloatArray { get; set; } = Array.Empty<float>();
    
    /// <summary>
    ///     Gets or sets test uint value.
    /// </summary>
    [DataMember(Name = "testUInt")]
    public virtual uint TestUInt { get; set; }
    
    /// <summary>
    ///     Gets or sets test uint array values.
    /// </summary>
    [DataMember(Name = "testUIntArray")]
    public virtual uint[] TestUIntArray { get; set; } = Array.Empty<uint>();
    
    /// <summary>
    ///     Gets or sets test char value.
    /// </summary>
    [DataMember(Name = "testChar")]
    public virtual char TestChar { get; set; }
    
    /// <summary>
    ///     Gets or sets test char array values.
    /// </summary>
    [DataMember(Name = "testCharArray")]
    public virtual char[] TestCharArray { get; set; } = Array.Empty<char>();
    
    /// <summary>
    ///     Gets or sets test byte value.
    /// </summary>
    [DataMember(Name = "testByte")]
    public virtual byte TestByte { get; set; }

    /// <summary>
    ///     Gets or sets test short value.
    /// </summary>
    [DataMember(Name = "testShort")]
    public virtual short TestShort { get; set; }
    
    /// <summary>
    ///     Gets or sets test short array values.
    /// </summary>
    [DataMember(Name = "testShortArray")]
    public virtual short[] TestShortArray { get; set; } = Array.Empty<short>();
    
    /// <summary>
    ///     Gets or sets test ushort value.
    /// </summary>
    [DataMember(Name = "testUShort")]
    public virtual ushort TestUShort { get; set; }
    
    /// <summary>
    ///     Gets or sets test ushort array values.
    /// </summary>
    [DataMember(Name = "testUShortArray")]
    public virtual ushort[] TestUShortArray { get; set; } = Array.Empty<ushort>();
    
    /// <summary>
    ///     Gets or sets test long value.
    /// </summary>
    [DataMember(Name = "testLong")]
    public virtual long TestLong { get; set; }

    /// <summary>
    ///     Gets or sets test long array values.
    /// </summary>
    [DataMember(Name = "testLongArray")]
    public virtual long[] TestLongArray { get; set; } = Array.Empty<long>();
    
    /// <summary>
    ///     Gets or sets test ulong value.
    /// </summary>
    [DataMember(Name = "testULong")]
    public virtual ulong TestULong { get; set; }
    
    /// <summary>
    ///     Gets or sets test ulong array values.
    /// </summary>
    [DataMember(Name = "testULongArray")]
    public virtual ulong[] TestULongArray { get; set; } = Array.Empty<ulong>();
    
    /// <summary>
    ///     Gets or sets test DateTime value.
    /// </summary>
    [DataMember(Name = "testDate")]
    public virtual DateTime TestDate { get; set; } = DateTime.UtcNow;
    
    /// <summary>
    ///     Gets or sets test TimeSpan value.
    /// </summary>
    [DataMember(Name = "testTimeSpan")]
    public virtual TimeSpan TestTimeSpan { get; set; } = TimeSpan.Zero;
}