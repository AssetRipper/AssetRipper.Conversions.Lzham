using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_len@lzdecision@lzcompressor@lzham@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl lzham::lzcompressor::lzdecision::get_len(void) const")]
[CleanName("Get_len")]
internal static partial class Get_len_wzf5xk
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return maximum_95ffuu.Invoke(unchecked((lzham_CLZDecompBase*)@this)->m_cur_state, 1);
	}
}
