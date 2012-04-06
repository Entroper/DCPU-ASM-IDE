using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DCPU_16.ASM
{
	public enum OpValue : byte
	{
		A = 0x00,
		B = 0x01,
		C = 0x02,
		X = 0x03,
		Y = 0x04,
		Z = 0x05,
		I = 0x06,
		J = 0x07,
		DereferenceRegister = 0x08,
		DereferenceNextWordPlusRegister = 0x10,
		POP = 0x18,
		PEEK = 0x19,
		PUSH = 0x1A,
		SP = 0x1B,
		PC = 0x1C,
		O = 0x1D,
		DereferenceNextWord = 0x1E,
		NextWordLiteral = 0x1F,
		Literal = 0x20
	}
}
