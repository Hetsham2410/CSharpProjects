using System;
namespace XMLDocumentation
{
    /// <include file="D:\Projects\C#\CSharpFundamentals\CSharpFundamentals\XMLDocumentation\XMLDocumentation.xml" path='doc/members[@name="generator"]/*'/>
    public class Generator
    {
        /// <value> value of last id sequence </value>
        public static int LastIdSequence { get; private set; } = 1;
        /// <summary>
        /// Generate Employee Id by processing <paramref name="fname"/>, <paramref name="lname"/>, <paramref name="hiredate"/>
        /// <list type="bullet">
        /// <item>
        /// <term>ID</term>
        /// <description>Employee Initials (first letter of <paramref name="lname"/> and first letter of <paramref name="fname"/>)</description>
        /// </item>
        /// <item>
        /// <term>YY</term>
        /// <description>Hire Date 2 digit year</description>
        /// </item>
        /// /// <item>
        /// <term>MM</term>
        /// <description>Hire Date 2 digit month</description>
        /// </item>
        /// /// <item>
        /// <term>DD</term>
        /// <description>Hire Date 2 digit day</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="hiredate"></param>
        /// <example>
        /// <code>
        /// var id = Generator.GenerateId("Jogn","Smith",new DateTime(2021, 06, 21, 0, 0, 0);
        /// Console.WriteLine(id);
        /// </code>
        /// </example>
        /// <returns>
        /// employee Id as a string
        /// </returns>
        /// <exception cref="System.InvalidOperationException">Thrown when <paramref name="fname"/>is null</exception>
        /// <exception cref="System.InvalidOperationException">Thrown when <paramref name="lname"/>is null</exception>
        /// <exception cref="System.InvalidOperationException">Thrown when <paramref name="hiredate"/>is in the past</exception>
        /// See <see cref="Generator.GenerateRandomPassword(int)"/> to Generate a random password

        public static string GenerateId(string fname, string lname, DateTime? hiredate)
        {
            if (fname is null)
                throw new InvalidOperationException($"{nameof(fname)}  can't be null");
            if (lname is null)
                throw new InvalidOperationException($"{nameof(lname)}  can't be null");
            if(hiredate is null)        
                hiredate = DateTime.Now;
            else
            {
                if (hiredate.Value.Date < DateTime.Now.Date)
                    throw new InvalidOperationException($"{nameof(hiredate)} can't ba in the past");
            }
            var yy = hiredate.Value.ToString("yy");
            var mm = hiredate.Value.ToString("MM");
            var dd = hiredate.Value.ToString("dd");
            var code = $"{lname.ToUpper()[0]}{fname.ToUpper()[0]}{yy}{mm}{dd}{(LastIdSequence++).ToString().PadLeft(2,'0')}";
            return code;
        }
        public static string GenerateRandomPassword(int length)
        {
            const string ValidScope = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789!@#$%^&*";
            var result = "";
            Random rnd = new Random();
            while(length-- > 0)            
                result += (ValidScope[rnd.Next(ValidScope.Length)]);
            return result;                        
        }

    }
}
