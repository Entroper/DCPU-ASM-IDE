using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DCPU_16.ASM
{
	public class Instruction
	{
		private OpCode opCode;
		public OpCode OpCode
		{
			get
			{
				return opCode;
			}
		}
		
		private OpValue opValueA, opValueB;

		public OpValue OpValueA
		{
			get
			{
				return opValueA;
			}
		}
		
		public OpValue OpValueB
		{
			get
			{
				return opValueB;
			}
		}
	}
}
