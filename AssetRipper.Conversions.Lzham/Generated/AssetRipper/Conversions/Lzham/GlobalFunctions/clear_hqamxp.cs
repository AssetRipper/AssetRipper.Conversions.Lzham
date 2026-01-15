using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::vector<class lzham::adaptive_bit_model>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_hqamxp
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_vector*)@this)->m_p != null)
			{
				destruct_array_dwzwyb.Invoke(n: ((lzham_vector*)@this)->m_size, p: ((lzham_vector*)@this)->m_p);
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
