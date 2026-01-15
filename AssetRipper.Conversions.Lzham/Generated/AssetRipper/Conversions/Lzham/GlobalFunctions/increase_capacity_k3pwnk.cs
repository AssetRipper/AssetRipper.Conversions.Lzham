using System;
using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?increase_capacity@elemental_vector@lzham@@QEAA_NI_NIP6AXPEAX1I@Z0@Z")]
[DemangledName("public: bool __cdecl lzham::elemental_vector::increase_capacity(unsigned int, bool, unsigned int, void (__cdecl *)(void *, void *, unsigned int), bool)")]
[CleanName("increase_capacity")]
internal static partial class increase_capacity_k3pwnk
{
	private partial struct LocalVariables
	{
		public long field_0;

		public InlineArray256_SByte field_1;

		public InlineArray256_SByte field_2;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("unsigned int")] int element_size, [NativeType("void (__cdecl *)(void *, void *, unsigned int)")] void* pMover, [NativeType("bool")] bool nofail)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0L;
		localsPointer->field_1 = default(InlineArray256_SByte);
		localsPointer->field_2 = default(InlineArray256_SByte);
		sbyte b = (nofail ? ((sbyte)1) : ((sbyte)0));
		sbyte b2 = (grow_hint ? ((sbyte)1) : ((sbyte)0));
		bool flag;
		unchecked
		{
			if ((uint)((lzham_vector*)@this)->m_capacity >= (uint)min_new_capacity)
			{
				flag = true;
			}
			else
			{
				long num = (uint)min_new_capacity;
				if ((b2 & 1) == 1 && !is_power_of_2_7smfqf.Invoke(num))
				{
					num = (uint)next_pow2_csqeav.Invoke(num);
				}
				long num2 = (uint)element_size * num;
				if (pMover == null)
				{
					void* ptr = lzham_realloc.Invoke(((lzham_vector*)@this)->m_p, num2, &localsPointer->field_0, movable: true);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					void* ptr2 = ptr;
					if (ptr2 == null)
					{
						if ((b & 1) == 1)
						{
							flag = false;
							goto IL_0261;
						}
						sprintf_s.Invoke(&localsPointer->field_1, 256L, String_c93t5e.__pointer, default(ReadOnlySpan<nint>));
						lzham_fail.Invoke(String_xra7zt.__pointer, String_qv32gu.__pointer, 42);
					}
					((lzham_vector*)@this)->m_p = ptr2;
				}
				else
				{
					void* ptr3 = lzham_malloc.Invoke(num2, &localsPointer->field_0);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					void* ptr4 = ptr3;
					if (ptr4 == null)
					{
						if ((b & 1) == 1)
						{
							flag = false;
							goto IL_0261;
						}
						sprintf_s.Invoke(&localsPointer->field_2, 256L, String_d6e2vj.__pointer, default(ReadOnlySpan<nint>));
						lzham_fail.Invoke(String_xra7zt.__pointer, String_qv32gu.__pointer, 56);
					}
					void* ptr5 = pMover;
					int size = ((lzham_vector*)@this)->m_size;
					((delegate*<void*, void*, int, void>)ptr5)(ptr4, ((lzham_vector*)@this)->m_p, size);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (((lzham_vector*)@this)->m_p != null)
					{
						lzham_free.Invoke(((lzham_vector*)@this)->m_p);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
					}
					((lzham_vector*)@this)->m_p = ptr4;
				}
				if ((ulong)localsPointer->field_0 > (ulong)num2)
				{
					((lzham_vector*)@this)->m_capacity = (int)((ulong)localsPointer->field_0 / (ulong)(uint)element_size);
				}
				else
				{
					((lzham_vector*)@this)->m_capacity = (int)num;
				}
				flag = true;
			}
			goto IL_0261;
		}
		IL_0261:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
