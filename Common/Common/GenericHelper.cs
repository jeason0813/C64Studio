using System;
using System.ComponentModel;
using System.Reflection;

namespace GR
{
  public class EnumHelper
  {
    public static string GetDescription( Enum en )
    {
      Type type = en.GetType();

      MemberInfo[] memInfo = type.GetMember( en.ToString() );

      if ( memInfo != null && memInfo.Length > 0 )
      {
        object[] attrs = memInfo[0].GetCustomAttributes( typeof( DescriptionAttribute ), false );

        if ( attrs != null && attrs.Length > 0 )
        {
          return ( (DescriptionAttribute)attrs[0] ).Description;
        }
      }

      return en.ToString();
    }
  }

  namespace Generic
  {

    public class Tupel<T1, T2>
    {
      public T1  first = default( T1 );
      public T2  second = default( T2 );

      public Tupel()
      {
      }

      public Tupel( T1 Value1, T2 Value2 )
      {
        first = Value1;
        second = Value2;
      }

      public override string ToString()
      {
        if ( first is string )
        {
          return first.ToString();
        }
        if ( second is string )
        {
          return second.ToString();
        }
        return base.ToString();
      }

    }
  }
  
  namespace Color
  {
    public static class Helper
    {
      public static System.Drawing.Color FromARGB( UInt32 Color )
      {
        return System.Drawing.Color.FromArgb( (int)Color );
      }
    }
      
  }
  
}