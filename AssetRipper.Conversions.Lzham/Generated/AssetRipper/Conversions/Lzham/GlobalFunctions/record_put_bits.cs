using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?record_put_bits@symbol_codec@lzham@@QEAA_NII@Z")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::record_put_bits(unsigned int, unsigned int)")]
internal static partial class record_put_bits
{
	private partial struct LocalVariables
	{
		public lzham_sym_freq field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int bits, [NativeType("unsigned int")] int num_bits)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_sym_freq);
		unchecked
		{
			bool flag;
			if (num_bits == 0)
			{
				flag = true;
			}
			else
			{
				((lzham_symbol_codec*)@this)->m_total_bits_written += num_bits;
				localsPointer->field_0.m_freq = bits;
				localsPointer->field_0.m_left = (short)num_bits;
				localsPointer->field_0.m_right = 0;
				bool flag2 = try_push_back_wrcwgy.Invoke(&((lzham_symbol_codec*)@this)->m_output_syms, &localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				flag = (flag2 ? true : false);
			}
			bool result = flag;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
