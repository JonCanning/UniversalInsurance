# UniversalInsurance
A simple rating engine for a quote business.

**Mindmap:**

Initial thoughts Mindmap can be found here: https://bubbl.us/?h=2a7f58/55c3e6/270CdPlJCIrfU&r=705985864

**Continuous Integration:**

Appveyor CI output can be viewed here: https://ci.appveyor.com/project/monkieboy/universalinsurance


**Criteria:**

Universal Insurance has decided to enter the car insurance market and require a rating engine to quote for business. The initial calculation that Universal want to implement is as follows:
	
Premium = Base premium for vehicle type * Factor for vehicle manufacturer

|Vehicle Type|Base Premium|
|------------|------------|
|Car|£800|
|Van|£1000|
 
|Vehicle manufacturer|Factor|
|--------------------|------|
|Audi|1.5|
|Mercedes|2.0|

Two examples are:
 
Example 1.
Input: Insurance required for Audi Car
Output: Premium = £1200 
 
Example 2.
Input: Mercedes Van 
Output: Premium = £2000

Please write some C# code to implement these requirements for Universal Insurance’s rating engine.
