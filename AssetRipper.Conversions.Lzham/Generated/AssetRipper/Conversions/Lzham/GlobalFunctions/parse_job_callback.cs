using System;
using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?parse_job_callback@lzcompressor@lzham@@AEAAX_KPEAX@Z")]
[DemangledName("private: void __cdecl lzham::lzcompressor::parse_job_callback(unsigned __int64, void *)")]
internal static partial class parse_job_callback
{
	private partial struct LocalVariables
	{
		public lzham_scoped_perf_section field_0;
	}

	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, void*, void>)(&Invoke));

	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned __int64")] long data, [NativeType("void *")] void* pData_ptr)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_scoped_perf_section);
		unchecked
		{
			int num = (int)data;
			_0scoped_perf_section.Invoke(&localsPointer->field_0, 0, String_kkiyv4.__pointer, default(ReadOnlySpan<nint>));
			void* parse_state = (byte*)(&((lzham_lzcompressor*)@this)->field_18) + (nint)(uint)num * (nint)sizeof(lzham_lzcompressor_parse_thread_state);
			if ((((lzham_lzcompressor*)@this)->field_1.m_lzham_compress_flags & 2) != 0 && ((lzham_lzcompressor*)@this)->field_1.m_compression_level == 4)
			{
				extreme_parse.Invoke(@this, parse_state);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
			}
			else
			{
				optimal_parse.Invoke(@this, parse_state);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
			}
			if (atomic_decrement32.Invoke(&((lzham_lzcompressor*)@this)->field_19) == 0)
			{
				release.Invoke((byte*)@this + 6444396, 1, null);
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
