using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?calculate_minimum_redundancy@lzham@@YAXQEAHH@Z")]
[DemangledName("void __cdecl lzham::calculate_minimum_redundancy(int *const, int)")]
internal static partial class calculate_minimum_redundancy
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("int *const")] void* A, [NativeType("int")] int n)
	{
		switch (n)
		{
		case 0:
			return;
		case 1:
			*unchecked((int*)A) = 0;
			return;
		}
		*unchecked((int*)A) += unchecked((int*)A)[1];
		int num = 0;
		int num2 = 2;
		int i;
		for (i = 1; i < n - 1; i++)
		{
			unchecked
			{
				if (num2 >= n || ((int*)A)[num] < ((int*)A)[num2])
				{
					((int*)A)[i] = ((int*)A)[num];
					((int*)A)[checked(num++)] = i;
				}
				else
				{
					((int*)A)[i] = ((int*)A)[checked(num2++)];
				}
			}
			if (num2 >= n || (num < i && unchecked(((int*)A)[num] < ((int*)A)[num2])))
			{
				unchecked((int*)A)[i] += unchecked((int*)A)[num];
				unchecked((int*)A)[num++] = i;
			}
			else
			{
				unchecked((int*)A)[i] += unchecked((int*)A)[num2++];
			}
		}
		unchecked((int*)A)[n - 2] = 0;
		for (i = n - 3; i >= 0; i += -1)
		{
			unchecked((int*)A)[i] = unchecked(((int*)A)[((int*)A)[i]]) + 1;
		}
		int j = 1;
		int num3 = 0;
		int num4 = 0;
		num = n - 2;
		i = n - 1;
		while (j > 0)
		{
			for (; num >= 0 && unchecked((int*)A)[num] == num3; num += -1)
			{
				num4++;
			}
			for (; j > num4; j += -1)
			{
				int num5 = num3;
				int num6 = i;
				i = num6 + -1;
				unchecked((int*)A)[num6] = num5;
			}
			j = 2 * num4;
			num3++;
			num4 = 0;
		}
	}
}
