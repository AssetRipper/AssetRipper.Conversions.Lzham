using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?encode_align_to_byte@symbol_codec@lzham@@QEAA_NXZ")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::encode_align_to_byte(void)")]
internal static partial class encode_align_to_byte
{
	private partial struct LocalVariables
	{
		public lzham_sym_freq field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_sym_freq);
		localsPointer->field_0.m_freq = 0;
		localsPointer->field_0.m_left = -2;
		localsPointer->field_0.m_right = 0;
		unchecked
		{
			bool flag = try_push_back_wrcwgy.Invoke(&((lzham_symbol_codec*)@this)->m_output_syms, &localsPointer->field_0);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			int result = (flag ? (-1) : 0);
			StackFrameList.Current.Clear(startFrame);
			return (byte)result != 0;
		}
	}
}
