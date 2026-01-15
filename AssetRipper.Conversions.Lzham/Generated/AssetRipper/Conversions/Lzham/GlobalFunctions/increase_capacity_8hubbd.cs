using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?increase_capacity@?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@AEAA_NI_N0@Z")]
[DemangledName("private: bool __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::increase_capacity(unsigned int, bool, bool)")]
[CleanName("increase_capacity")]
internal static partial class increase_capacity_8hubbd
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result = increase_capacity_k3pwnk.Invoke(@this, min_new_capacity, ((grow_hint ? 1u : 0u) & 1u) == 1, 8, null, ((nofail ? 1u : 0u) & 1u) == 1);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		return result;
	}
}
