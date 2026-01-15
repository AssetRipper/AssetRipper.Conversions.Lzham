using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?clear@?$vector@Uoutput_symbol@symbol_codec@lzham@@@lzham@@QEAAXXZ")]
[DemangledName("public: void __cdecl lzham::vector<struct lzham::symbol_codec::output_symbol>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_rvrac9
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_vector*)@this)->m_p != null)
			{
				destruct_array_6e56yk.Invoke(n: ((lzham_vector*)@this)->m_size, p: ((lzham_vector*)@this)->m_p);
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
