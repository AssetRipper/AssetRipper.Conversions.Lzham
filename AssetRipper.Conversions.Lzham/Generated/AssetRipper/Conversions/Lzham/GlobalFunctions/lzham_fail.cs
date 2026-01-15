using System;
using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_fail@@YAXPEBD0I@Z")]
[DemangledName("void __cdecl lzham_fail(char const *, char const *, unsigned int)")]
internal static partial class lzham_fail
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("char const *")] void* pExp, [NativeType("char const *")] void* pFile, [NativeType("unsigned int")] int line)
	{
		InlineArray512_SByte inlineArray512_SByte = default(InlineArray512_SByte);
		sprintf_s.Invoke(&inlineArray512_SByte, 512L, String_ww2gga.__pointer, default(ReadOnlySpan<nint>));
		lzham_output_debug_string.Invoke(&inlineArray512_SByte);
		printf.Invoke(String_289y69.__pointer, default(ReadOnlySpan<nint>));
		if ((g_exit_on_failure.Value & 1) != 1)
		{
			return;
		}
		exit.Invoke(1);
		throw null;
	}
}
