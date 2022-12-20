#C#知识点




Console.WriteLine/ReadLIne()；
//换行输出/输入
Console.Write/Read();
//不换行输出/输入
//（默认输入为字符串类型）
Console.WriteLine("{0}+{1}={2}",a,b,a+b);
//使用该格式可以将,后面的变量按照从0开始的顺序赋值给{}，例如将a赋值给{0}

Convert.ToInt32();
//使用此函数可以将其它数据类型（一般是字符串）变为Int32

Random rd = new Random(Key(可选));//此可以生成一个新的随机序列（默认以当前系统时间为种子）
int RandKey = rd.Next(a,b)；//将指定区间[a,b)的随机数赋值给RandomKey

static void Add(params int[] array)
//params可以传递任意个参数