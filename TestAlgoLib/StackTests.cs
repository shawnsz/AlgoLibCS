using System;
using Xunit;
using AlgoLib;

namespace TestAlgoLib
{
    public class StackTests
    {
        public class EmptyStack
        {
            Stack<int> stack;

            public EmptyStack()
            {
                stack = new Stack<int>();
            }

            [Fact]
            public void Size_ShouldReturnZero()
            {
                Assert.Equal(0, stack.Size);
            }

            [Fact]
            public void isEmpty_ShouldReturnTrue()
            {
                Assert.True(stack.isEmpty());
            }

            [Fact]
            public void Pop_ShouldThrowInvalidOperationException()
            {
                Exception exception = Record.Exception(() => stack.Pop());

                Assert.IsType<InvalidOperationException>(exception);
            }

            [Fact]
            public void Push_ShouldGotOneElement()
            {
                stack.Push(12);

                Assert.Equal(1, stack.Size);
            }
        }

        public class StackWithMultipleValues
        {
            Stack<int> stack;
            const int firstValue = 8;
            const int secondValue = 2;
            const int thirdValue = 9;

            public StackWithMultipleValues()
            {
                stack = new Stack<int>();
                stack.Push(firstValue);
                stack.Push(secondValue);
                stack.Push(thirdValue);
            }

            [Fact]
            public void Size_ShouldBeThree()
            {
                int count = stack.Size;

                Assert.Equal(3, count);
            }

            [Fact]
            public void Pop_ShouldBeLifo()
            {
                Assert.Equal(thirdValue, stack.Pop());
                Assert.Equal(secondValue, stack.Pop());
                Assert.Equal(firstValue, stack.Pop());
            }

            [Fact]
            public void isEmpty_ShouldBeFalse()
            {
                Assert.False(stack.isEmpty());
            }
        }

        public class StackWithStrings
        {
            [Fact]
            public void Pop_ShouldReturnPushedString()
            {
                Stack<string> stack = new Stack<string>();
                stack.Push("Hello");

                Assert.Equal(1, stack.Size);
                string retEle = stack.Pop();
                Assert.Equal("Hello", retEle);
            }
        }

        public class StackWithObjects
        {
            [Fact]
            public void Pop_ShouldReturnPushedObject()
            {
                Stack<SampleClass> stack = new Stack<SampleClass>();
                stack.Push(new SampleClass(1, "Dog"));
                stack.Push(new SampleClass(2, "Cat"));
                stack.Push(new SampleClass(3, "Bird"));

                Assert.Equal(3, stack.Size);
                Assert.Equal("Bird", stack.Pop().Name);
            }
        }

        class SampleClass
        {
            public int Id { get; }
            public string Name { get; }

            public SampleClass(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

        }
    }
}