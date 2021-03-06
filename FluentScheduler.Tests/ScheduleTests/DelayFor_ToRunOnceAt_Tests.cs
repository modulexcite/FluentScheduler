using System;
using FluentScheduler.Model;
using Moq;
using NUnit.Framework;

namespace FluentScheduler.Tests.ScheduleTests
{
	[TestFixture]
	public class DelayFor_ToRunNow_Tests
	{
		[Test]
		public void Should_Delay_ToRunNow_For_2_Seconds()
		{
			TaskManager.AddTask(() => { }, x => x.WithName("Should_Delay_ToRunNow_For_2_Seconds").ToRunNow().DelayFor(2).Seconds());
			DateTime expectedTime = DateTime.Now.AddSeconds(2);

			DateTime actualTime = TaskManager.GetSchedule("Should_Delay_ToRunNow_For_2_Seconds").NextRunTime;

			Assert.AreEqual(Math.Floor(expectedTime.TimeOfDay.TotalSeconds), Math.Floor(actualTime.TimeOfDay.TotalSeconds));
		}
		[Test]
		public void Should_Delay_ToRunNow_For_2_Minutes()
		{
			TaskManager.AddTask(() => { }, x => x.WithName("Should_Delay_ToRunNow_For_2_Minutes").ToRunNow().DelayFor(2).Minutes());
			DateTime expectedTime = DateTime.Now.AddMinutes(2);

			DateTime actualTime = TaskManager.GetSchedule("Should_Delay_ToRunNow_For_2_Minutes").NextRunTime;

			Assert.AreEqual(Math.Floor(expectedTime.TimeOfDay.TotalSeconds), Math.Floor(actualTime.TimeOfDay.TotalSeconds));
		}
		[Test]
		public void Should_Delay_ToRunNow_For_2_Hours()
		{
			TaskManager.AddTask(() => { }, x => x.WithName("Should_Delay_ToRunNow_For_2_Hours").ToRunNow().DelayFor(2).Hours());
			DateTime expectedTime = DateTime.Now.AddHours(2);

			DateTime actualTime = TaskManager.GetSchedule("Should_Delay_ToRunNow_For_2_Hours").NextRunTime;

			Assert.AreEqual(Math.Floor(expectedTime.TimeOfDay.TotalSeconds), Math.Floor(actualTime.TimeOfDay.TotalSeconds));
		}
		[Test]
		public void Should_Delay_ToRunNow_For_2_Days()
		{
			TaskManager.AddTask(() => { }, x => x.WithName("Should_Delay_ToRunNow_For_2_Days").ToRunNow().DelayFor(2).Days());
			DateTime expectedTime = DateTime.Now.AddDays(2);

			DateTime actualTime = TaskManager.GetSchedule("Should_Delay_ToRunNow_For_2_Days").NextRunTime;

			Assert.AreEqual(Math.Floor(expectedTime.TimeOfDay.TotalSeconds), Math.Floor(actualTime.TimeOfDay.TotalSeconds));
		}
		[Test]
		public void Should_Delay_ToRunNow_For_2_Weeks()
		{
			TaskManager.AddTask(() => { }, x => x.WithName("Should_Delay_ToRunNow_For_2_Weeks").ToRunNow().DelayFor(2).Weeks());
			DateTime expectedTime = DateTime.Now.AddDays(14);

			DateTime actualTime = TaskManager.GetSchedule("Should_Delay_ToRunNow_For_2_Weeks").NextRunTime;

			Assert.AreEqual(Math.Floor(expectedTime.TimeOfDay.TotalSeconds), Math.Floor(actualTime.TimeOfDay.TotalSeconds));
		}
		[Test]
		public void Should_Delay_ToRunNow_For_2_Months()
		{
			TaskManager.AddTask(() => { }, x => x.WithName("Should_Delay_ToRunNow_For_2_Months").ToRunNow().DelayFor(2).Months());
			DateTime expectedTime = DateTime.Now.AddMonths(2);

			DateTime actualTime = TaskManager.GetSchedule("Should_Delay_ToRunNow_For_2_Months").NextRunTime;

			Assert.AreEqual(Math.Floor(expectedTime.TimeOfDay.TotalSeconds), Math.Floor(actualTime.TimeOfDay.TotalSeconds));
		}
		[Test]
		public void Should_Delay_ToRunNow_For_2_Years()
		{
			TaskManager.AddTask(() => { }, x => x.WithName("Should_Delay_ToRunNow_For_2_Years").ToRunNow().DelayFor(2).Years());
			DateTime expectedTime = DateTime.Now.AddYears(2);

			DateTime actualTime = TaskManager.GetSchedule("Should_Delay_ToRunNow_For_2_Years").NextRunTime;

			Assert.AreEqual(Math.Floor(expectedTime.TimeOfDay.TotalSeconds), Math.Floor(actualTime.TimeOfDay.TotalSeconds));
		}

	}
}
