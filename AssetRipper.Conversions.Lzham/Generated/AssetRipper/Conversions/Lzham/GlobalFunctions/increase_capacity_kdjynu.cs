using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?increase_capacity@?$vector@Ulzpriced_decision@lzcompressor@lzham@@@lzham@@AEAA_NI_N0@Z")]
[DemangledName("private: bool __cdecl lzham::vector<struct lzham::lzcompressor::lzpriced_decision>::increase_capacity(unsigned int, bool, bool)")]
[CleanName("increase_capacity")]
internal static partial class increase_capacity_kdjynu
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("bool")] bool nofail)
	{
		bool result = increase_capacity_k3pwnk.Invoke(@this, min_new_capacity, ((grow_hint ? 1u : 0u) & 1u) == 1, 24, object_mover_rddqd7.__pointer, ((nofail ? 1u : 0u) & 1u) == 1);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		return result;
	}
}
