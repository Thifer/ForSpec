string[] input = {"asdgh","qwerfsaf","aws","zxc","asdfqa"};
string[] output;
int count = 0;


for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length < 4) count++;
}

output = new string[count];
count = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length < 4)
    {
        output[count] = input[i];
        count++;
    }
}

for (int i = 0; i < output.Length; i++)
{
    Console.WriteLine(output[i]);
}
