using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0?$vector@Vadaptive_bit_model@lzham@@@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::vector<class lzham::adaptive_bit_model>::vector<class lzham::adaptive_bit_model>(void)")]
internal static partial class vector_class_lzham_adaptive_bit_model_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((lzham_vector*)@this)->m_p = null;
			((lzham_vector*)@this)->m_size = 0;
			((lzham_vector*)@this)->m_capacity = 0;
			return @this;
		}
	}
}
