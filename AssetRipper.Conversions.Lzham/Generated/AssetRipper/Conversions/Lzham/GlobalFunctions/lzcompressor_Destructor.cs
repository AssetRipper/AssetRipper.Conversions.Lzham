using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1lzcompressor@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::lzcompressor::~lzcompressor(void)")]
internal static partial class lzcompressor_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			semaphore_Destructor.Invoke((byte*)@this + 6444396);
			lzham_lzcompressor_parse_thread_state* field_ = (lzham_lzcompressor_parse_thread_state*)(&((lzham_lzcompressor*)@this)->field_18);
			nint num = (nint)(field_ + 9L);
			while (true)
			{
				lzham_lzcompressor_parse_thread_state* ptr = (lzham_lzcompressor_parse_thread_state*)(num + (nint)(-1) * sizeof(lzham_lzcompressor_parse_thread_state));
				parse_thread_state_Destructor.Invoke(ptr);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				if (ptr == field_)
				{
					break;
				}
				num = (nint)ptr;
			}
			state_Destructor.Invoke(&((lzham_lzcompressor*)@this)->field_16);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			state_Destructor.Invoke(&((lzham_lzcompressor*)@this)->field_15);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_char_Destructor.Invoke(&((lzham_lzcompressor*)@this)->field_9);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_char_Destructor.Invoke(&((lzham_lzcompressor*)@this)->field_8);
			if (ExceptionInfo.Current == null)
			{
				symbol_codec_Destructor.Invoke(&((lzham_lzcompressor*)@this)->field_6);
				if (ExceptionInfo.Current == null)
				{
					search_accelerator_Destructor.Invoke(&((lzham_lzcompressor*)@this)->field_5);
				}
			}
		}
	}
}
