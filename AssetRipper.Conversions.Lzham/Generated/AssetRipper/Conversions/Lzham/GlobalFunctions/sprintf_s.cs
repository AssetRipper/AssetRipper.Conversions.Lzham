using System;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class sprintf_s
{
	public unsafe static int Invoke([MangledName("_Buffer")] void* Buffer, [MangledName("_BufferCount")] long BufferCount, [MangledName("_Format")] void* Format, ReadOnlySpan<nint> args)
	{
		void* argList = null;
		InstructionHelper.VAStart(&argList, args);
		return vsprintf_s_l.Invoke(Buffer, BufferCount, Format, null, argList);
	}
}
