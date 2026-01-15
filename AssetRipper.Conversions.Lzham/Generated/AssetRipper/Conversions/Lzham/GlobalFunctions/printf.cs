using System;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

internal static partial class printf
{
	public unsafe static int Invoke([MangledName("_Format")] void* Format, ReadOnlySpan<nint> args)
	{
		void* ptr = null;
		InstructionHelper.VAStart(&ptr, args);
		return vfprintf_l.Invoke(ArgList: ptr, Stream: acrt_iob_func.Invoke(1), Format: Format, Locale: null);
	}
}
