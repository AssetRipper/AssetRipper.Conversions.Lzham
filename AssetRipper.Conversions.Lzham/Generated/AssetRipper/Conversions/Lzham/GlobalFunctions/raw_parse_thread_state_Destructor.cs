using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1raw_parse_thread_state@lzcompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzcompressor::raw_parse_thread_state::~raw_parse_thread_state(void)")]
internal static partial class raw_parse_thread_state_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			vector_struct_lzham_lzcompressor_lzpriced_decision_Destructor.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)@this)->m_temp_decisions);
			if (ExceptionInfo.Current == null)
			{
				vector_struct_lzham_lzcompressor_lzdecision_Destructor.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)@this)->m_best_decisions);
				if (ExceptionInfo.Current == null)
				{
					state_Destructor.Invoke(&((lzham_lzcompressor_raw_parse_thread_state*)@this)->m_initial_state);
				}
			}
		}
	}
}
