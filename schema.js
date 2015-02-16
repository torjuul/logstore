{
	appId: "guid",
	accessToken: "guid",
	
	id: "guid"
	logMessage: "",	
	logLevel: "",
	time: "ISO datetime",
	
	context: {
		http: {
			requestId: "guid",		
			uri: "string"
		},
		application: {
			workingSet: "long", // amount of memory in bytes,
			currentDirectory: "string",
			threadCount: "int",
			startTime: "ISO datetime",
			virtualMemorySize: "long",
			privateMemorySize: "
		},
		env: {
			machineName: "string",
			processId: "string",
			threadId: "guid",
			threadName: "string",
			bootDevice: "string",
			buildNumber: "string",
			caption: "string",
			codeset: "string",
			countryCode: "string",
			currentTimezone: "string",
		}
	}
}
