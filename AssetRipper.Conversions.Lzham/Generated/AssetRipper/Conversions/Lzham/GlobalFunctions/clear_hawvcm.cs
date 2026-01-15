using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@?$vector@Ulzdecision@lzcompressor@lzham@@@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::vector<struct lzham::lzcompressor::lzdecision>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_hawvcm
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_vector*)@this)->m_p != null)
			{
				destruct_array_d9vgvt.Invoke(n: ((lzham_vector*)@this)->m_size, p: ((lzham_vector*)@this)->m_p);
				lzham_free.Invoke(((lzham_vector*)@this)->m_p);
				if (ExceptionInfo.Current == null)
				{
					((lzham_vector*)@this)->m_p = null;
					((lzham_vector*)@this)->m_size = 0;
					((lzham_vector*)@this)->m_capacity = 0;
				}
			}
		}
	}
}
