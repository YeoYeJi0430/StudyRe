using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeftModule.ViewModels
{
    public class MessageViewModel : BindableBase
    {
        IEventAggregator _ea; // _ea로 데이터를 주고받음

        //Message,SendMessageCommand
        private string message;
        public string Message
        {
            get => message;
            set => SetProperty(ref message, value);
        }

        public DelegateCommand SendMessageCommand { get; set; }

        //생성자
        public MessageViewModel(IEventAggregator ea)
        {
            _ea = ea;
            SendMessageCommand = new DelegateCommand(SendMessage); //sendmessage버튼누를때 이벤트
        }

        private void SendMessage()
        {
            //메서드 실행시 메시지 던지는 동작 실행
            _ea.GetEvent<MessageSentEvent>().Publish(Message); //메시지 던져줌

        }

    }
}
