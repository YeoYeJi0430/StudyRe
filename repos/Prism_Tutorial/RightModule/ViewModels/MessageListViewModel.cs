using Prism.Events;
using Prism.Mvvm;
using PrismApp.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RightModule.ViewModels
{
    public class MessageListViewModel : BindableBase
    {
        IEventAggregator _ea;

        //Messages
        private ObservableCollection<string> messages;
        public ObservableCollection<string> Messages
        {
            get => messages;
            set => SetProperty(ref messages, value);
        }

        public MessageListViewModel(IEventAggregator ea)
        {
            _ea = ea;
            Messages = new ObservableCollection<string>();//초기화생성
            //_ea.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);//메시지 받음
            _ea.GetEvent<MessageSentEvent>().Subscribe(MessageReceived,ThreadOption.PublisherThread,false,
                (filter)=>filter.Contains("Prism"));//필터링
        }

        private void MessageReceived(string message)
        {
            Messages.Add(message);//받은 메시지 추가
        }
    }
}
