﻿using Android.App.Admin;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CloseMauiAppTest;

public class MainViewModel : INotifyPropertyChanged
{
	private string _message = "Welcome";
	
	public event PropertyChangedEventHandler? PropertyChanged;


	public MainViewModel()
	{ 
		TestOneCommand = new Command(TestOne);
	}

	protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public string Message
	{
		get
		{
			return _message;
		}
		set
		{
			_message = value;
			OnPropertyChanged();
		}
	}

	public Command TestOneCommand { get; set; }

	void TestOne()
	{
		Message = "Test 1 Running";
		_ = Task.Run(() => LongTask());
	}

	private void LongTask()
	{
		Thread.Sleep(2000);
		DoneEvent?.Invoke();
	}
}