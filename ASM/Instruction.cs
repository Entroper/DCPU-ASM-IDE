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

		public void Parse(string instructionText)
		{
			throw new NotImplementedException();
		}

		public void Parse(short[] instructionBinary, short index)
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			throw new NotImplementedException();
		}

		public short[] ToBinary()
		{
			throw new NotImplementedException();
		}
	}
}
