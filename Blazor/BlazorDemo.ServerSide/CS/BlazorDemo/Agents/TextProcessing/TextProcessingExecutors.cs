using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Agents.AI.Workflows;

namespace BlazorDemo.Agents.TextProcessing {
    public sealed class UppercaseExecutor : Executor<string, string> {
        public UppercaseExecutor() : base("UppercaseExecutor") { }

        public override ValueTask<string> HandleAsync(
            string message, IWorkflowContext context, CancellationToken cancellationToken = default) =>
            ValueTask.FromResult(message.ToUpperInvariant());
    }

    public sealed class ReverseTextExecutor : Executor<string, string> {
        public ReverseTextExecutor() : base("ReverseTextExecutor") { }

        public override ValueTask<string> HandleAsync(
            string message, IWorkflowContext context, CancellationToken cancellationToken = default) =>
            ValueTask.FromResult(string.Concat(message.Reverse()));
    }
}
