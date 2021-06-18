# CAP Theorem

I'd say this is my first foot in the door at learning about Distributed Systems and I mean anything with the word `Theorem` in it may sound incredibly complex but when it's broken down and explained it's really quite simple.

In Essence the CAP Theorem is a tradeoff we have to make every time we get a network issue.

As this is the real world network issues are fairly common and every system needs to be designed with this in mind.

CAP Stands for

- Consistency
- Availability
- Partition Tolerant

And the Theory goes as such...

You can only have at most two of the three parts that make up the CAP Triad (Think triad is the right word... well i hope so anyway)


In Distributed Systems we thus need to make a tradeoff between Consistency and Availability in case we get a 'Partition' aka a network issue.

So do we;

A) Allow Consistency either between Databases or Data Storages / UI by not allowing the user to do certain things until we have a connection with the DB again.

B) Allow for Availability and tradeoff having consistent data across our sources.

You might be asking Kodey, Don't we always want a highly available system why does it matter.

In Some cases it might actually make more sense to have a Consistency across our data sources for example;

- Booking Seats anywhere so you don't get overbooked.
- Payment to ensure people can't pretend to of paid when they haven't

However in other cases we want to prioritize Availability and tradeoff consistent data across our streams.

For example;

- Editing Notes on your phone
- Playing mobile games offline then syncing after you have a connection


So In summary:

Due to the Universe we can't have everything we ever wanted to have. And we can only settle on two out of the three. In the case of a network failure we have a choice to make as developers. Do we give the User consistency or availability and that choice will depend on what exactly your priorities are...