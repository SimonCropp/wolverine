// <auto-generated/>
#pragma warning disable

namespace Internal.Generated.WolverineHandlers
{
    // START: Message2Handler700775183
    public class Message2Handler700775183 : Wolverine.Runtime.Handlers.MessageHandler
    {


        public override System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            var messageHandler = new ConsoleApp.MessageHandler();
            var message2 = (TestMessages.Message2)context.Envelope.Message;
            messageHandler.Handle(message2);
            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: Message2Handler700775183
    
    
}
