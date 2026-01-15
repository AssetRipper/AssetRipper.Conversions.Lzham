using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1lzham_compress_state@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzham_compress_state::~lzham_compress_state(void)")]
internal static partial class lzham_compress_state_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		lzcompressor_Destructor.Invoke(&unchecked((lzham_lzham_compress_state*)@this)->m_compressor);
		if (ExceptionInfo.Current == null)
		{
			task_pool_Destructor.Invoke(@this);
		}
	}
}
