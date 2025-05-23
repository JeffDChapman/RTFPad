using System;
using System.Globalization;

namespace RTFPad.Dictionary.Phonetic
{
	/// <summary>
	///		This class holds helper methods for phonetic encoding
	/// </summary>
	public sealed class PhoneticUtility
	{
		/// <summary>
		///     Initializes a new instance of the class
		/// </summary>
		private PhoneticUtility()
		{
		}

		/// <summary>
		///     Converts the rule text in to a PhoneticRule class
		/// </summary>
		/// <param name="ruleText" type="string">
		///     <para>
		///         The text to convert
		///     </para>
		/// </param>
		/// <param name="rule" type="ref RTFPad.Dictionary.Phonetic.PhoneticRule">
		///     <para>
		///         The object that will hold the conversion data
		///     </para>
		/// </param>
		public static void EncodeRule(string ruleText, ref PhoneticRule rule)
		{
			// clear the conditions array
			for (int i=0; i < rule.Condition.Length; i++)
			{
				rule.Condition[i] = 0;
			}

			bool group = false;  /* group indicator */
			bool end = false;   /* end condition indicator */

			char [] memberChars = new char[200];
			int numMember = 0;   /* number of member in group */

			foreach (char cond in ruleText)
			{
				switch (cond) 
				{
					case '(' :
						group = true;
						break;
					case ')' :
						end = true;
						break;
					case '^' :
						rule.BeginningOnly = true;
						break;
					case '$' :
						rule.EndOnly = true;
						break;
					case '-' :
						rule.ConsumeCount++;
						break;
					case '<' :
						rule.ReplaceMode = true;
						break;
					case '0' :
					case '1' :
					case '2' :
					case '3' :
					case '4' :
					case '5' :
					case '6' :
					case '7' :
					case '8' :
					case '9' :
						rule.Priority = int.Parse(cond.ToString(CultureInfo.CurrentUICulture));
						break;
					default :
						if (group)
						{
							// add chars to group
							memberChars[numMember] = cond;
							numMember++;
						}
						else
						{
							end = true;
						}
						break;
				} // switch

				if (end)
				{
					if (group)
					{
						// turn on chars in member group
						for (int j=0; j < numMember; j++) 
						{
							int charCode = (int)memberChars[j];
							rule.Condition[charCode] = rule.Condition[charCode] | (1 << rule.ConditionCount);
						}

						group = false;
						numMember = 0;
					}
					else
					{
						// turn on char
						int charCode = (int)cond;
						rule.Condition[charCode] = rule.Condition[charCode] | (1 << rule.ConditionCount);
					}
					end = false;
					rule.ConditionCount++;
				} // if end
			} // for each
		}
	}
}
