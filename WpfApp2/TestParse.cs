using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
	class TestParse
	{
		public static string PrintScobe(string s) 
		{
			var count = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] != '+' && s[i] != '*' && s[i] != '-' && s[i] != '[' && s[i] != ']' && s[i] != '^' && s[i] != '_' && s[i] != '/' && s[i] != '{' && s[i] != '}')
				{
					if (count == 0)
					{
						s = s.Insert(i, "{");
						i++;
						count++;
					}
					
				}
				else if (s[i] == '[' || s[i] == ']')
				{
					if (s[i] == '[')
					{
						s = s.Insert(i+1, "{");
						s = s.Insert(i, "{");
						i++;
					}
					if (s[i] == ']')
					{
						s = s.Insert(i + 1, "}");
						s = s.Insert(i, "}");
						i++;
					}
				}
				else if (count > 0)
				{
					s = s.Insert(i, "}");
					count--;
				}
			}
			count = s.Count(chr => chr == '{') - s.Count(chr => chr == '}');
			return (count != 0) 
					? s + "}"
					: s;
		}

		public static string PrintDel(string s) 
		{
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '/')
				{
					var index = i+6;
					var count = 0;
					for (int j = i-1; j >= 0; j--)
					{
						if (s[j] == '}')
						{
							count++;
						}
						if (s[j] == '{')
						{
							count--;
						}
						if (count == 0)
						{
							s = s.Insert(j, @"{\frac");
							break;
						}
					}
					for (int j = index + 1; j <= s.Length; j++)
					{
						if (s[j] == '}')
						{
							count++;
						}
						if (s[j] == '{')
						{
							count--;
						}
						if (count == 0)
						{
							s = s.Insert(j, @"}");
							break;
						}
					}
					s = s.Remove(index,1);
				}
			}

			return s;
		}
	}
}
