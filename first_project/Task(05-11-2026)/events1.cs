using System;

// 1. Create Delegate
//Access_Specifier delegate retuyrn_type delagate_name()
public delegate void VotingCountChangedHandler(
    object sender,//Which object raised the event?
    string Constituency,
    int newVotingCount
);

// 2. Publisher Class
public class Election
{
    //3. Create Event
    //Access_specifier event delagate_name event_name
    public event VotingCountChangedHandler VotingCountChanged;

    private int votingCount;

    public string Constituency { get; }

    //4.  Constructor
    public Election(string Constituency, int initialVotingCount)
    {
        Constituency = Constituency;
        votingCount = initialVotingCount;
    }

    //4. Business Logic
    public int VotingCount
    {
        get
        {
            return votingCount;
        }

        set
        {
            if (votingCount != value)
            {
                votingCount = value;

                //5. Raise Event
                OnVotingCountChanged(Constituency, value);
            }
        }
    }

    //6.  Event Handler Method
    protected void OnVotingCountChanged(
        string Constituency,
        int newVotingCount)
    {
        //7. call all Subscribers
        VotingCountChanged?.Invoke(
            this,
            Constituency,
            newVotingCount
        );
    }
}

// 8. Subscriber Class - District
public class District
{
    public static void UpdateToDistrictOffice(
        object sender,
        string Constituency,
        int newVotingCount
    )
    {
        Console.WriteLine(
            "District Office: " + Constituency +
            " - " + newVotingCount
        );
    }
}

// 8. Subscriber Class - State
public class State
{
    public static void UpdateToStateOffice(
        object sender,
        string Constituency,
        int newVotingCount)
    {
        Console.WriteLine(
            "State Office: " + Constituency +
            " - " + newVotingCount
        );
    }
}

// 8. Subscriber Class - Union
public class Union
{
    public static void UpdateToUnionOffice(
        object sender,
        string Constituency,
        int newVotingCount)
    {
        Console.WriteLine(
            "Union Office: " + Constituency +
            " - " + newVotingCount
        );
    }
}


class Events1
{
    static void Main()
    {
        Election election =
            new Election("Madurai", 0);


        //9.Add Subscribers
        // Subscribe methods to event
        election.VotingCountChanged +=
            District.UpdateToDistrictOffice;

        election.VotingCountChanged +=
            State.UpdateToStateOffice;

        election.VotingCountChanged +=
            Union.UpdateToUnionOffice;

        // 10. Logic Call [Change voting count]
        Console.WriteLine("First Update:");

        election.VotingCount = 123;

        Console.WriteLine();

        Console.WriteLine("Second Update:");

        election.VotingCount = 456;

        Console.WriteLine();

        //11. Unsubscribe District- OPtional
        election.VotingCountChanged -=
            District.UpdateToDistrictOffice;

        Console.WriteLine("Third Update:");

        election.VotingCount = 789;
    }
}