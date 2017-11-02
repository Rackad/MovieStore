# ASP.NET-Demo
Build ASP.NET MVC on IBM Cloud


# Pre Requisite

1. IBM Cloud Account, [here](http://ibm.biz/aspappworkshop)
2. IBM Cloud CLI, [<img src="http://incitrio.com/wp-content/uploads/2015/01/Apple_gray_logo.png" width=23 height=23>](https://clis.ng.bluemix.net/download/bluemix-cli/0.6.0/osx) or <img src="https://image.flaticon.com/icons/svg/220/220215.svg" width=15 height=15> [32bit](https://clis.ng.bluemix.net/download/bluemix-cli/0.6.0/win32)/[64bit](https://clis.ng.bluemix.net/download/bluemix-cli/0.6.0/win64)


# Instructions

## Step 1

1. Clone the Project : 
`$ git clone https://github.com/Rashid-j/MovieStore.git`

2. Navigate to Folder: `Models`
3. Open `Movie.cs` in you favorite editor

4. Add the following attributes for `Movie` object

```
  public string id { get; set; }
  public string title { get; set; }
  public int year { get; set; }
```

5. Define the constructor

```
  public Movie(dynamic info)
  {

    id = info.imdbId;
    title = info.title;
    year = info.releaseYear;

  }
```

> Movie.cs 
<img src="https://image.ibb.co/grByvw/Screen_Shot_2017_10_31_at_10_33_33_AM.png" width=320 height=250>


## Step 2

1. Navigate to Folder: `Controllers`
2. Open `HomeController.cs` in you favorite editor

3. Load the data stream from the variable `url`
```
  var json = new WebClient().DownloadString(url);
```

4. Desrialize JSON results to .NET Object
```
  dynamic obj = JsonConvert.DeserializeObject(json);
```

5. Populate the model `Movies` that uses the previous model we defined `Movie`
```
  Movies movies = new Movies(obj);
```

> HomeController.cs 
<img src="https://image.ibb.co/ixGFaw/Screen_Shot_2017_10_31_at_10_34_28_AM.png" width=900 height=300>


## Step 3

1. Open PowerShell or Terminal
2. Navigate the main project directory
3. Type in the CLI [Command-Line Interface], and follow by your credential
```
  $ bx login 
```
4. Deploy the application to IBM Cloud
```
  $ bx app push myDemo
```
5. Verify your applications list
```
  $ bx app list
```

Place the listed url in your Browser, 

[<img src=https://media.giphy.com/media/3o7aCRtrt0f4tQLkkM/giphy.gif>]()

## Congrats! your app is up & running on IBM Cloud ⛅️ 
