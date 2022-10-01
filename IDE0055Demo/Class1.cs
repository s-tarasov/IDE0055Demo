namespace IDE0055Demo;
public class Class1
{
    static void Method1()
    {
        Enumerable.Range(1,  1)
            .Select(x => x.ToString())
            // Comment here cause warnings when LF.
            .ToArray();

    }
}
