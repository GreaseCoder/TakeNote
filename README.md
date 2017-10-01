# NoteAPI

## Running the Application
Executables have been built for win7-x64 and win10-x64.  They can be found here:
```
TakeNote/TakeNote/bin/Release/netcoreapp1.1/win7-x64
TakeNote/TakeNote/bin/Release/netcoreapp1.1/win10-x64
```
Running the executable will launch the application, and provide you a default port to access the API through.

## The Note Model
```json
{
 "id" : 1,
 "body" : "Ask Larry about the TPS reports."
}
```

## Creating a New Note
```
curl -i -H "Content-Type: application/json" -X POST -d '{"body" : "Pick up milk!"}' http://localhost/api/notes
```

## Getting an Existing Note
```
curl -i -H "Content-Type: application/json" -X GET http://localhost/api/notes/1
```
Returns
```json
{
 "id" : 1,
 "body" : "Pick up milk!"
}
```

## Get All Notes
```
curl -i -H "Content-Type: application/json" -X GET http://localhost/api/notes
```
Returns
```json
[
 {
  "id" : 2,
  "body" : "Pick up milk!"
 },
 {
  "id" : 1,
  "body" : "Ask Larry about the TPS reports."
 }
]
```

## Search Notes
```
curl -i -H "Content-Type: application/json" -X GET http://localhost/api/notes?query=milk
```
Returns a list of every note with the work "milk" in it.
