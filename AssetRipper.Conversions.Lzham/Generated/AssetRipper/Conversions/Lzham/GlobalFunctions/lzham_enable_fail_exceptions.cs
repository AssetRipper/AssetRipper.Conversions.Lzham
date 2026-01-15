using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_enable_fail_exceptions@@YAX_N@Z")]
[DemangledName("void __cdecl lzham_enable_fail_exceptions(bool)")]
internal static partial class lzham_enable_fail_exceptions
{
	[return: NativeType("void")]
	public static void Invoke([NativeType("bool")] bool enabled)
	{
		g_fail_exceptions.Value = ((((enabled ? 1u : 0u) & 1u) == 1) ? ((sbyte)1) : ((sbyte)0));
	}
}
