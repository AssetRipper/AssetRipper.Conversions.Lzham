using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1decoder_tables@prefix_coding@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::prefix_coding::decoder_tables::~decoder_tables(void)")]
internal static partial class decoder_tables_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((lzham_prefix_coding_decoder_tables*)@this)->m_lookup != null)
			{
				lzham_delete_array_g5z2nn.Invoke(((lzham_prefix_coding_decoder_tables*)@this)->m_lookup);
				if (ExceptionInfo.Current != null)
				{
					goto IL_0051;
				}
			}
			if (((lzham_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order == null)
			{
				return;
			}
			lzham_delete_array_i9xite.Invoke(((lzham_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order);
			if (ExceptionInfo.Current == null)
			{
				return;
			}
			goto IL_0051;
		}
		IL_0051:
		ExceptionInfo.Current = null;
		std_terminate.Invoke();
		throw null;
	}
}
