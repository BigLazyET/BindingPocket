using System;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using Metal;
using ObjCRuntime;
using UIKit;
using MetalKit;

namespace ObjCRuntime
{
    // @protocol RiveFallbackFontProvider
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol (Name = "_TtP11RiveRuntime24RiveFallbackFontProvider_"), Model]
    // [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface RiveFallbackFontProvider
    {
        // @required @property (readonly, nonatomic, strong) UIFont * _Nonnull fallbackFont;
        [Abstract]
        [Export ("fallbackFont", ArgumentSemantic.Strong)]
        UIFont FallbackFont { get; }
    }
}

namespace RiveRuntime.iOS
{
	// @interface RenderContext : NSObject
	[BaseType (typeof(NSObject))]
	interface RenderContext
	{
	}
	
	[Static]
	// [Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double RiveRuntimeVersionNumber;
		[Field ("RiveRuntimeVersionNumber", "__Internal")]
		double RiveRuntimeVersionNumber { get; }

		// extern const unsigned char[] RiveRuntimeVersionString;
		[Field ("RiveRuntimeVersionString", "__Internal")]
		NSString RiveRuntimeVersionString { get; }
		
		// extern NSString *const _Nonnull RiveErrorDomain;
		[Field ("RiveErrorDomain", "__Internal")]
		NSString RiveErrorDomain { get; }
	}

	// typedef _Bool (^LoadAsset)(RiveFileAsset *, NSData *, RiveFactory *);
	// typedef _Bool (^LoadAsset)(RiveFileAsset * _Nonnull, NSData * _Nonnull, RiveFactory * _Nonnull);
	delegate bool LoadAsset (RiveFileAsset arg0, NSData arg1, RiveFactory arg2);

	// @interface RiveFile : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveFile
	{
		// @property (readonly, class) uint majorVersion;
		[Static]
		[Export ("majorVersion")]
		uint MajorVersion { get; }

		// @property (readonly, class) uint minorVersion;
		[Static]
		[Export ("minorVersion")]
		uint MinorVersion { get; }

		// @property _Bool isLoaded;
		[Export ("isLoaded")]
		bool IsLoaded { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		RiveFileDelegate Delegate { get; set; }

		// @property (weak) id _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) NSUInteger viewModelCount;
		[Export ("viewModelCount")]
		nuint ViewModelCount { get; }

		// -(instancetype _Nullable)initWithByteArray:(NSArray * _Nonnull)bytes loadCdn:(_Bool)cdn error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithByteArray:loadCdn:error:")]
		// [Verify (StronglyTypedNSArray)]
		NativeHandle Constructor (NSObject[] bytes, bool cdn, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithByteArray:(NSArray * _Nonnull)bytes loadCdn:(_Bool)cdn customAssetLoader:(LoadAsset _Nonnull)customAssetLoader error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithByteArray:loadCdn:customAssetLoader:error:")]
		// [Verify (StronglyTypedNSArray)]
		NativeHandle Constructor (NSObject[] bytes, bool cdn, LoadAsset customAssetLoader, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithBytes:(UInt8 * _Nonnull)bytes byteLength:(UInt64)length loadCdn:(_Bool)cdn error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithBytes:byteLength:loadCdn:error:")]
		unsafe NativeHandle Constructor (byte* bytes, ulong length, bool cdn, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithBytes:(UInt8 * _Nonnull)bytes byteLength:(UInt64)length loadCdn:(_Bool)cdn customAssetLoader:(LoadAsset _Nonnull)customAssetLoader error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithBytes:byteLength:loadCdn:customAssetLoader:error:")]
		unsafe NativeHandle Constructor (byte* bytes, ulong length, bool cdn, LoadAsset customAssetLoader, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithData:(NSData * _Nonnull)bytes loadCdn:(_Bool)cdn error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithData:loadCdn:error:")]
		NativeHandle Constructor (NSData bytes, bool cdn, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithData:(NSData * _Nonnull)bytes loadCdn:(_Bool)cdn customAssetLoader:(LoadAsset _Nonnull)customAssetLoader error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithData:loadCdn:customAssetLoader:error:")]
		NativeHandle Constructor (NSData bytes, bool cdn, LoadAsset customAssetLoader, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithResource:(NSString * _Nonnull)resourceName withExtension:(NSString * _Nonnull)extension loadCdn:(_Bool)cdn error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithResource:withExtension:loadCdn:error:")]
		NativeHandle Constructor (string resourceName, string extension, bool cdn, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithResource:(NSString * _Nonnull)resourceName withExtension:(NSString * _Nonnull)extension loadCdn:(_Bool)cdn customAssetLoader:(LoadAsset _Nonnull)customAssetLoader error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithResource:withExtension:loadCdn:customAssetLoader:error:")]
		NativeHandle Constructor (string resourceName, string extension, bool cdn, LoadAsset customAssetLoader, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithResource:(NSString * _Nonnull)resourceName loadCdn:(_Bool)cdn error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithResource:loadCdn:error:")]
		NativeHandle Constructor (string resourceName, bool cdn, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithResource:(NSString * _Nonnull)resourceName loadCdn:(_Bool)cdn customAssetLoader:(LoadAsset _Nonnull)customAssetLoader error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithResource:loadCdn:customAssetLoader:error:")]
		NativeHandle Constructor (string resourceName, bool cdn, LoadAsset customAssetLoader, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithHttpUrl:(NSString * _Nonnull)url loadCdn:(_Bool)cdn withDelegate:(id<RiveFileDelegate> _Nonnull)delegate;
		[Export ("initWithHttpUrl:loadCdn:withDelegate:")]
		NativeHandle Constructor (string url, bool cdn, RiveFileDelegate @delegate);

		// -(instancetype _Nullable)initWithHttpUrl:(NSString * _Nonnull)url loadCdn:(_Bool)cdn customAssetLoader:(LoadAsset _Nonnull)customAssetLoader withDelegate:(id<RiveFileDelegate> _Nonnull)delegate;
		[Export ("initWithHttpUrl:loadCdn:customAssetLoader:withDelegate:")]
		NativeHandle Constructor (string url, bool cdn, LoadAsset customAssetLoader, RiveFileDelegate @delegate);

		// -(RiveArtboard * _Nullable)artboard:(NSError * _Nullable * _Nullable)error;
		[Export ("artboard:")]
		[return: NullAllowed]
		RiveArtboard Artboard ([NullAllowed] out NSError error);

		// -(NSInteger)artboardCount;
		[Export ("artboardCount")]
		// [Verify (MethodToProperty)]
		nint ArtboardCount { get; }

		// -(RiveArtboard * _Nullable)artboardFromIndex:(NSInteger)index error:(NSError * _Nullable * _Nullable)error;
		[Export ("artboardFromIndex:error:")]
		[return: NullAllowed]
		RiveArtboard ArtboardFromIndex (nint index, [NullAllowed] out NSError error);

		// -(RiveArtboard * _Nullable)artboardFromName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
		[Export ("artboardFromName:error:")]
		[return: NullAllowed]
		RiveArtboard ArtboardFromName (string name, [NullAllowed] out NSError error);

		// -(NSArray<NSString *> * _Nonnull)artboardNames;
		[Export ("artboardNames")]
		// [Verify (MethodToProperty)]
		string[] ArtboardNames { get; }

		// -(RiveDataBindingViewModel * _Nullable)viewModelAtIndex:(NSUInteger)index;
		[Export ("viewModelAtIndex:")]
		[return: NullAllowed]
		RiveDataBindingViewModel ViewModelAtIndex (nuint index);

		// -(RiveDataBindingViewModel * _Nullable)viewModelNamed:(NSString * _Nonnull)name;
		[Export ("viewModelNamed:")]
		[return: NullAllowed]
		RiveDataBindingViewModel ViewModelNamed (string name);

		// -(RiveDataBindingViewModel * _Nullable)defaultViewModelForArtboard:(RiveArtboard * _Nonnull)artboard;
		[Export ("defaultViewModelForArtboard:")]
		[return: NullAllowed]
		RiveDataBindingViewModel DefaultViewModelForArtboard (RiveArtboard artboard);

		// -(RiveBindableArtboard * _Nullable)bindableArtboardWithName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
		[Export ("bindableArtboardWithName:error:")]
		[return: NullAllowed]
		RiveBindableArtboard BindableArtboardWithName (string name, [NullAllowed] out NSError error);

		// -(RiveBindableArtboard * _Nullable)defaultBindableArtboard:(NSError * _Nullable * _Nullable)error;
		[Export ("defaultBindableArtboard:")]
		[return: NullAllowed]
		RiveBindableArtboard DefaultBindableArtboard ([NullAllowed] out NSError error);
	}

	// @protocol RiveFileDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface RiveFileDelegate
	{
		// @required -(BOOL)riveFileDidLoad:(RiveFile * _Nonnull)riveFile error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export ("riveFileDidLoad:error:")]
		bool RiveFileDidLoad (RiveFile riveFile, [NullAllowed] out NSError error);

		// @required -(void)riveFileDidError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("riveFileDidError:")]
		void RiveFileDidError (NSError error);
	}

	// @interface RiveArtboard : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveArtboard
	{
		// @property (assign, nonatomic) float volume __attribute__((swift_private));
		[Export ("volume")]
		float Volume { get; set; }

		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }

		// -(CGRect)bounds;
		[Export ("bounds")]
		// [Verify (MethodToProperty)]
		CGRect Bounds { get; }

		// -(double)width;
		// -(void)setWidth:(double)value;
		[Export ("width")]
		// [Verify (MethodToProperty)]
		double Width { get; set; }

		// -(double)height;
		// -(void)setHeight:(double)value;
		[Export ("height")]
		// [Verify (MethodToProperty)]
		double Height { get; set; }

		// -(void)resetArtboardSize;
		[Export ("resetArtboardSize")]
		void ResetArtboardSize ();

		// -(const RiveSMIBool * _Nonnull)getBool:(NSString * _Nonnull)name path:(NSString * _Nonnull)path;
		[Export ("getBool:path:")]
		RiveSMIBool GetBool (string name, string path);

		// -(const RiveSMITrigger * _Nonnull)getTrigger:(NSString * _Nonnull)name path:(NSString * _Nonnull)path;
		[Export ("getTrigger:path:")]
		RiveSMITrigger GetTrigger (string name, string path);

		// -(const RiveSMINumber * _Nonnull)getNumber:(NSString * _Nonnull)name path:(NSString * _Nonnull)path;
		[Export ("getNumber:path:")]
		RiveSMINumber GetNumber (string name, string path);

		// -(NSInteger)animationCount;
		[Export ("animationCount")]
		nint AnimationCount ();

		// -(NSArray<NSString *> * _Nonnull)animationNames;
		[Export ("animationNames")]
		string[] AnimationNames ();

		// -(RiveLinearAnimationInstance * _Nullable)animationFromIndex:(NSInteger)index error:(NSError * _Nullable * _Nullable)error;
		[Export ("animationFromIndex:error:")]
		[return: NullAllowed]
		RiveLinearAnimationInstance AnimationFromIndex (nint index, [NullAllowed] out NSError error);

		// -(RiveLinearAnimationInstance * _Nullable)animationFromName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
		[Export ("animationFromName:error:")]
		[return: NullAllowed]
		RiveLinearAnimationInstance AnimationFromName (string name, [NullAllowed] out NSError error);

		// -(NSInteger)stateMachineCount;
		[Export ("stateMachineCount")]
		nint StateMachineCount ();

		// -(NSArray<NSString *> * _Nonnull)stateMachineNames;
		[Export ("stateMachineNames")]
		string[] StateMachineNames ();

		// -(RiveStateMachineInstance * _Nullable)stateMachineFromIndex:(NSInteger)index error:(NSError * _Nullable * _Nullable)error;
		[Export ("stateMachineFromIndex:error:")]
		[return: NullAllowed]
		RiveStateMachineInstance StateMachineFromIndex (nint index, [NullAllowed] out NSError error);

		// -(RiveStateMachineInstance * _Nullable)stateMachineFromName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
		[Export ("stateMachineFromName:error:")]
		[return: NullAllowed]
		RiveStateMachineInstance StateMachineFromName (string name, [NullAllowed] out NSError error);

		// -(RiveStateMachineInstance * _Nullable)defaultStateMachine;
		[Export ("defaultStateMachine")]
		[return: NullAllowed]
		RiveStateMachineInstance DefaultStateMachine ();

		// -(RiveTextValueRun * _Nullable)textRun:(NSString * _Nonnull)name;
		[Export ("textRun:")]
		[return: NullAllowed]
		RiveTextValueRun TextRun (string name);

		// -(RiveTextValueRun * _Nullable)textRun:(NSString * _Nonnull)name path:(NSString * _Nonnull)path;
		[Export ("textRun:path:")]
		[return: NullAllowed]
		RiveTextValueRun TextRun (string name, string path);

		// -(void)advanceBy:(double)elapsedSeconds;
		[Export ("advanceBy:")]
		void AdvanceBy (double elapsedSeconds);

		// // -(void)draw:(RiveRenderer * _Nonnull)renderer;
		// [Export ("draw:")]
		// void Draw (RiveRenderer renderer);

		// -(void)bindViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance __attribute__((swift_name("bind(viewModelInstance:)")));
		[Export ("bindViewModelInstance:")]
		void BindViewModelInstance (RiveDataBindingViewModelInstance instance);
	}

	// @interface RiveBindableArtboard : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveBindableArtboard
	{
		// @property (readonly, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }
	}

	// @interface RiveSMIInput : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveSMIInput
	{
		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }

		// -(_Bool)isBoolean;
		[Export ("isBoolean")]
		// [Verify (MethodToProperty)]
		bool IsBoolean { get; }

		// -(_Bool)isTrigger;
		[Export ("isTrigger")]
		// [Verify (MethodToProperty)]
		bool IsTrigger { get; }

		// -(_Bool)isNumber;
		[Export ("isNumber")]
		// [Verify (MethodToProperty)]
		bool IsNumber { get; }
	}

	// @interface RiveSMITrigger : RiveSMIInput
	[BaseType (typeof(RiveSMIInput))]
	interface RiveSMITrigger
	{
		// -(void)fire;
		[Export ("fire")]
		void Fire ();
	}

	// @interface RiveSMIBool : RiveSMIInput
	[BaseType (typeof(RiveSMIInput))]
	interface RiveSMIBool
	{
		// -(_Bool)value;
		// -(void)setValue:(_Bool)newValue;
		[Export ("value")]
		// [Verify (MethodToProperty)]
		bool Value { get; set; }
	}

	// @interface RiveSMINumber : RiveSMIInput
	[BaseType (typeof(RiveSMIInput))]
	interface RiveSMINumber
	{
		// -(float)value;
		// -(void)setValue:(float)newValue;
		[Export ("value")]
		// [Verify (MethodToProperty)]
		float Value { get; set; }
	}

	// @interface RiveLinearAnimationInstance : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveLinearAnimationInstance
	{
		// -(float)time;
		// -(void)setTime:(float)time;
		[Export ("time")]
		// [Verify (MethodToProperty)]
		float Time { get; set; }

		// -(float)endTime;
		[Export ("endTime")]
		float EndTime ();

		// -(_Bool)advanceBy:(double)elapsedSeconds;
		[Export ("advanceBy:")]
		bool AdvanceBy (double elapsedSeconds);

		// -(int)direction;
		[Export ("direction")]
		int Direction ();

		// -(void)direction:(int)direction;
		[Export ("direction:")]
		void Direction (int direction);

		// -(int)loop;
		[Export ("loop")]
		int Loop ();

		// -(void)loop:(int)loopMode;
		[Export ("loop:")]
		void Loop (int loopMode);

		// -(_Bool)didLoop;
		[Export ("didLoop")]
		bool DidLoop ();

		// -(NSString * _Nonnull)name;
		[Export ("name")]
		string Name ();

		// -(NSInteger)fps;
		[Export ("fps")]
		nint Fps ();

		// -(NSInteger)workStart;
		[Export ("workStart")]
		nint WorkStart ();

		// -(NSInteger)workEnd;
		[Export ("workEnd")]
		nint WorkEnd ();

		// -(NSInteger)duration;
		[Export ("duration")]
		nint Duration ();

		// -(NSInteger)effectiveDuration;
		[Export ("effectiveDuration")]
		nint EffectiveDuration ();

		// -(float)effectiveDurationInSeconds;
		[Export ("effectiveDurationInSeconds")]
		float EffectiveDurationInSeconds ();

		// -(_Bool)hasEnded;
		[Export ("hasEnded")]
		bool HasEnded ();
	}

	// @interface RiveStateMachineInstance : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveStateMachineInstance
	{
		// @property (readonly, nonatomic) RiveDataBindingViewModelInstance * _Nullable viewModelInstance;
		[NullAllowed, Export ("viewModelInstance")]
		RiveDataBindingViewModelInstance ViewModelInstance { get; }

		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }

		// -(_Bool)advanceBy:(double)elapsedSeconds;
		[Export ("advanceBy:")]
		bool AdvanceBy (double elapsedSeconds);

		// -(const RiveSMIBool * _Nonnull)getBool:(NSString * _Nonnull)name;
		[Export ("getBool:")]
		RiveSMIBool GetBool (string name);

		// -(const RiveSMITrigger * _Nonnull)getTrigger:(NSString * _Nonnull)name;
		[Export ("getTrigger:")]
		RiveSMITrigger GetTrigger (string name);

		// -(const RiveSMINumber * _Nonnull)getNumber:(NSString * _Nonnull)name;
		[Export ("getNumber:")]
		RiveSMINumber GetNumber (string name);

		// -(NSArray<NSString *> * _Nonnull)inputNames;
		[Export ("inputNames")]
		// [Verify (MethodToProperty)]
		string[] InputNames { get; }

		// -(NSInteger)inputCount;
		[Export ("inputCount")]
		// [Verify (MethodToProperty)]
		nint InputCount { get; }

		// -(NSInteger)layerCount;
		[Export ("layerCount")]
		// [Verify (MethodToProperty)]
		nint LayerCount { get; }

		// -(RiveSMIInput * _Nullable)inputFromIndex:(NSInteger)index error:(NSError * _Nullable * _Nullable)error;
		[Export ("inputFromIndex:error:")]
		[return: NullAllowed]
		RiveSMIInput InputFromIndex (nint index, [NullAllowed] out NSError error);

		// -(RiveSMIInput * _Nullable)inputFromName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
		[Export ("inputFromName:error:")]
		[return: NullAllowed]
		RiveSMIInput InputFromName (string name, [NullAllowed] out NSError error);

		// -(NSInteger)stateChangedCount;
		[Export ("stateChangedCount")]
		// [Verify (MethodToProperty)]
		nint StateChangedCount { get; }

		// -(RiveLayerState * _Nullable)stateChangedFromIndex:(NSInteger)index error:(NSError * _Nullable * _Nullable)error;
		[Export ("stateChangedFromIndex:error:")]
		[return: NullAllowed]
		RiveLayerState StateChangedFromIndex (nint index, [NullAllowed] out NSError error);

		// -(NSArray<NSString *> * _Nonnull)stateChanges;
		[Export ("stateChanges")]
		// [Verify (MethodToProperty)]
		string[] StateChanges { get; }

		// -(NSInteger)reportedEventCount;
		[Export ("reportedEventCount")]
		// [Verify (MethodToProperty)]
		nint ReportedEventCount { get; }

		// -(const RiveEvent * _Nonnull)reportedEventAt:(NSInteger)index;
		[Export ("reportedEventAt:")]
		RiveEvent ReportedEventAt (nint index);

		// -(RiveHitResult)touchBeganAtLocation:(CGPoint)touchLocation;
		[Export ("touchBeganAtLocation:")]
		RiveHitResult TouchBeganAtLocation (CGPoint touchLocation);

		// -(RiveHitResult)touchBeganAtLocation:(CGPoint)touchLocation touchID:(int)touchID;
		[Export ("touchBeganAtLocation:touchID:")]
		RiveHitResult TouchBeganAtLocation (CGPoint touchLocation, int touchID);

		// -(RiveHitResult)touchMovedAtLocation:(CGPoint)touchLocation;
		[Export ("touchMovedAtLocation:")]
		RiveHitResult TouchMovedAtLocation (CGPoint touchLocation);

		// -(RiveHitResult)touchMovedAtLocation:(CGPoint)touchLocation touchID:(int)touchID;
		[Export ("touchMovedAtLocation:touchID:")]
		RiveHitResult TouchMovedAtLocation (CGPoint touchLocation, int touchID);

		// -(RiveHitResult)touchEndedAtLocation:(CGPoint)touchLocation;
		[Export ("touchEndedAtLocation:")]
		RiveHitResult TouchEndedAtLocation (CGPoint touchLocation);

		// -(RiveHitResult)touchEndedAtLocation:(CGPoint)touchLocation touchID:(int)touchID;
		[Export ("touchEndedAtLocation:touchID:")]
		RiveHitResult TouchEndedAtLocation (CGPoint touchLocation, int touchID);

		// -(RiveHitResult)touchCancelledAtLocation:(CGPoint)touchLocation;
		[Export ("touchCancelledAtLocation:")]
		RiveHitResult TouchCancelledAtLocation (CGPoint touchLocation);

		// -(RiveHitResult)touchCancelledAtLocation:(CGPoint)touchLocation touchID:(int)touchID;
		[Export ("touchCancelledAtLocation:touchID:")]
		RiveHitResult TouchCancelledAtLocation (CGPoint touchLocation, int touchID);

		// -(RiveHitResult)touchExitedAtLocation:(CGPoint)touchLocation;
		[Export ("touchExitedAtLocation:")]
		RiveHitResult TouchExitedAtLocation (CGPoint touchLocation);

		// -(RiveHitResult)touchExitedAtLocation:(CGPoint)touchLocation touchID:(int)touchID;
		[Export ("touchExitedAtLocation:touchID:")]
		RiveHitResult TouchExitedAtLocation (CGPoint touchLocation, int touchID);

		// -(void)bindViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance __attribute__((swift_name("bind(viewModelInstance:)")));
		[Export ("bindViewModelInstance:")]
		void BindViewModelInstance (RiveDataBindingViewModelInstance instance);
	}

	// @interface RiveTextValueRun : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveTextValueRun
	{
		// -(NSString * _Nonnull)text;
		// -(void)setText:(NSString * _Nonnull)newValue;
		[Export ("text")]
		// [Verify (MethodToProperty)]
		string Text { get; set; }
	}

	// // @interface RiveEventReport : NSObject
	// [BaseType (typeof(NSObject))]
	// interface RiveEventReport
	// {
	// 	// -(float)secondsDelay;
	// 	[Export ("secondsDelay")]
	// 	// [Verify (MethodToProperty)]
	// 	float SecondsDelay { get; }
	// }

	// @interface RiveEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveEvent
	{
		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }

		// -(NSInteger)type;
		[Export ("type")]
		// [Verify (MethodToProperty)]
		nint Type { get; }

		// -(float)delay;
		[Export ("delay")]
		// [Verify (MethodToProperty)]
		float Delay { get; }

		// -(NSDictionary<NSString *,id> * _Nonnull)properties;
		[Export ("properties")]
		// [Verify (MethodToProperty)]
		NSDictionary<NSString, NSObject> Properties { get; }
	}

	// @interface RiveGeneralEvent : RiveEvent
	[BaseType (typeof(RiveEvent))]
	interface RiveGeneralEvent
	{
	}

	// @interface RiveOpenUrlEvent : RiveEvent
	[BaseType (typeof(RiveEvent))]
	interface RiveOpenUrlEvent
	{
		// -(NSString * _Nonnull)url;
		[Export ("url")]
		// [Verify (MethodToProperty)]
		string Url { get; }

		// -(NSString * _Nonnull)target;
		[Export ("target")]
		// [Verify (MethodToProperty)]
		string Target { get; }
	}

	// @interface RiveLayerState : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveLayerState
	{
		// -(const void * _Nonnull)rive_layer_state;
		[Export ("rive_layer_state")]
		// [Verify (MethodToProperty)]
		IntPtr Rive_layer_state { get; }

		// -(_Bool)isEntryState;
		[Export ("isEntryState")]
		// [Verify (MethodToProperty)]
		bool IsEntryState { get; }

		// -(_Bool)isExitState;
		[Export ("isExitState")]
		// [Verify (MethodToProperty)]
		bool IsExitState { get; }

		// -(_Bool)isAnyState;
		[Export ("isAnyState")]
		// [Verify (MethodToProperty)]
		bool IsAnyState { get; }

		// -(_Bool)isAnimationState;
		[Export ("isAnimationState")]
		// [Verify (MethodToProperty)]
		bool IsAnimationState { get; }

		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }
	}

	// @interface RiveExitState : RiveLayerState
	[BaseType (typeof(RiveLayerState))]
	interface RiveExitState
	{
		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }
	}

	// @interface RiveEntryState : RiveLayerState
	[BaseType (typeof(RiveLayerState))]
	interface RiveEntryState
	{
		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }
	}

	// @interface RiveAnyState : RiveLayerState
	[BaseType (typeof(RiveLayerState))]
	interface RiveAnyState
	{
		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }
	}

	// @interface RiveAnimationState : RiveLayerState
	[BaseType (typeof(RiveLayerState))]
	interface RiveAnimationState
	{
		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }
	}

	// @interface RiveUnknownState : RiveLayerState
	[BaseType (typeof(RiveLayerState))]
	interface RiveUnknownState
	{
		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }
	}

	// @interface RenderContextManager : NSObject
	[BaseType (typeof(NSObject))]
	interface RenderContextManager
	{
		// @property RendererType defaultRenderer;
		[Export ("defaultRenderer", ArgumentSemantic.Assign)]
		RendererType DefaultRenderer { get; set; }

		// +(RenderContextManager *)shared;
		[Static]
		[Export ("shared")]
		// [Verify (MethodToProperty)]
		RenderContextManager Shared { get; }

		// -(RenderContext *)newDefaultContext;
		[Export ("newDefaultContext")]
		// [Verify (MethodToProperty)]
		RenderContext NewDefaultContext { get; }

		// -(RenderContext *)newRiveContext;
		[Export ("newRiveContext")]
		// [Verify (MethodToProperty)]
		RenderContext NewRiveContext { get; }

		// -(RenderContext *)newCGContext;
		[Export ("newCGContext")]
		// [Verify (MethodToProperty)]
		RenderContext NewCGContext { get; }
	}

	// @interface RiveRenderImage : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveRenderImage
	{
		// -(instancetype _Nullable)initWithData:(NSData * _Nonnull)data;
		[Export ("initWithData:")]
		NativeHandle Constructor (NSData data);
	}

	// @interface RiveAudio : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveAudio
	{
	}

	// @interface RiveFactory : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveFactory
	{
		// -(RiveFont * _Nonnull)decodeFont:(NSData * _Nonnull)data;
		[Export ("decodeFont:")]
		RiveFont DecodeFont (NSData data);

		// -(RiveFont * _Nullable)decodeUIFont:(UIFont * _Nonnull)data __attribute__((swift_name("decodeFont(_:)")));
		[Export ("decodeUIFont:")]
		[return: NullAllowed]
		RiveFont DecodeUIFont (UIFont data);

		// -(RiveRenderImage * _Nonnull)decodeImage:(NSData * _Nonnull)data;
		[Export ("decodeImage:")]
		RiveRenderImage DecodeImage (NSData data);

		// -(RiveAudio * _Nullable)decodeAudio:(NSData * _Nonnull)data;
		[Export ("decodeAudio:")]
		[return: NullAllowed]
		RiveAudio DecodeAudio (NSData data);
	}

	// @interface RiveFileAsset : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveFileAsset
	{
		// -(NSString * _Nonnull)name;
		[Export ("name")]
		// [Verify (MethodToProperty)]
		string Name { get; }

		// -(NSString * _Nonnull)uniqueName;
		[Export ("uniqueName")]
		// [Verify (MethodToProperty)]
		string UniqueName { get; }

		// -(NSString * _Nonnull)uniqueFilename;
		[Export ("uniqueFilename")]
		// [Verify (MethodToProperty)]
		string UniqueFilename { get; }

		// -(NSString * _Nonnull)fileExtension;
		[Export ("fileExtension")]
		// [Verify (MethodToProperty)]
		string FileExtension { get; }

		// -(NSString * _Nonnull)cdnBaseUrl;
		[Export ("cdnBaseUrl")]
		// [Verify (MethodToProperty)]
		string CdnBaseUrl { get; }

		// -(NSString * _Nonnull)cdnUuid;
		[Export ("cdnUuid")]
		// [Verify (MethodToProperty)]
		string CdnUuid { get; }
	}

	// @interface RiveImageAsset : RiveFileAsset
	[BaseType (typeof(RiveFileAsset))]
	interface RiveImageAsset
	{
		// @property (readonly, nonatomic) CGSize size;
		[Export ("size")]
		CGSize Size { get; }

		// -(void)renderImage:(RiveRenderImage * _Nonnull)image;
		[Export ("renderImage:")]
		void RenderImage (RiveRenderImage image);
	}

	// @interface RiveFontAsset : RiveFileAsset
	[BaseType (typeof(RiveFileAsset))]
	interface RiveFontAsset
	{
		// -(void)font:(RiveFont * _Nonnull)font;
		[Export ("font:")]
		void Font (RiveFont font);
	}

	// @interface RiveAudioAsset : RiveFileAsset
	[BaseType (typeof(RiveFileAsset))]
	interface RiveAudioAsset
	{
		// -(void)audio:(RiveAudio * _Nonnull)audio;
		[Export ("audio:")]
		void Audio (RiveAudio audio);
	}

	// @interface RiveFileAssetLoader : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveFileAssetLoader
	{
		// -(BOOL)loadContentsWithAsset:(RiveFileAsset *)asset andData:(NSData *)data andFactory:(RiveFactory *)factory;
		[Export ("loadContentsWithAsset:andData:andFactory:")]
		bool LoadContentsWithAsset (RiveFileAsset asset, NSData data, RiveFactory factory);
	}

	// @interface CDNFileAssetLoader : RiveFileAssetLoader
	[BaseType (typeof(RiveFileAssetLoader))]
	interface CDNFileAssetLoader
	{
	}

	// @interface FallbackFileAssetLoader : RiveFileAssetLoader
	[BaseType (typeof(RiveFileAssetLoader))]
	interface FallbackFileAssetLoader
	{
		// -(void)addLoader:(RiveFileAssetLoader *)loader;
		[Export ("addLoader:")]
		void AddLoader (RiveFileAssetLoader loader);
	}

	// @interface CustomFileAssetLoader : RiveFileAssetLoader
	[BaseType (typeof(RiveFileAssetLoader))]
	interface CustomFileAssetLoader
	{
		// @property (copy, nonatomic) LoadAsset loadAsset;
		[Export ("loadAsset", ArgumentSemantic.Copy)]
		LoadAsset LoadAsset { get; set; }

		// -(instancetype)initWithLoader:(LoadAsset)loader;
		[Export ("initWithLoader:")]
		NativeHandle Constructor (LoadAsset loader);
	}

	// @interface RiveFontStyle : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface RiveFontStyle : INSCopying
	{
		// @property (readonly, nonatomic) RiveFontStyleWeight weight;
		[Export ("weight")]
		RiveFontStyleWeight Weight { get; }

		// @property (readonly, nonatomic) CGFloat rawWeight;
		[Export ("rawWeight")]
		nfloat RawWeight { get; }

		// -(instancetype _Nonnull)initWithWeight:(RiveFontStyleWeight)weight;
		[Export ("initWithWeight:")]
		NativeHandle Constructor (RiveFontStyleWeight weight);

		// -(instancetype _Nonnull)initWithRawWeight:(CGFloat)rawWeight;
		[Export ("initWithRawWeight:")]
		NativeHandle Constructor (nfloat rawWeight);
	}
	
// 	// @protocol RiveFallbackFontProvider
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
// 	[Protocol (Name = "_TtP11RiveRuntime24RiveFallbackFontProvider_"), Model]
// 	// [Protocol, Model]
// 	[BaseType (typeof(NSObject))]
// 	interface RiveFallbackFontProvider
// 	{
// 		// @required @property (readonly, nonatomic, strong) UIFont * _Nonnull fallbackFont;
// 		[Abstract]
// 		[Export ("fallbackFont", ArgumentSemantic.Strong)]
// 		UIFont FallbackFont { get; }
// 	}

	// typedef NSArray<id<RiveFallbackFontProvider>> * _Nonnull (^RiveFallbackFontsCallback)(RiveFontStyle * _Nonnull);
	delegate RiveFallbackFontProvider[] RiveFallbackFontsCallback (RiveFontStyle arg0);

	// @interface RiveFont : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveFont
	{
		// @property (copy, class) NSArray<id<RiveFallbackFontProvider>> * _Nonnull fallbackFonts;
		[Static]
		[Export ("fallbackFonts", ArgumentSemantic.Copy)]
		RiveFallbackFontProvider[] FallbackFonts { get; set; }

		// @property (copy, nonatomic, class) RiveFallbackFontsCallback _Nonnull fallbackFontsCallback;
		[Static]
		[Export ("fallbackFontsCallback", ArgumentSemantic.Copy)]
		RiveFallbackFontsCallback FallbackFontsCallback { get; set; }
	}

	// @interface RiveDataBindingViewModel : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveDataBindingViewModel
	{
		// @property (readonly, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) NSUInteger instanceCount;
		[Export ("instanceCount")]
		nuint InstanceCount { get; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull instanceNames;
		[Export ("instanceNames")]
		string[] InstanceNames { get; }

		// @property (readonly, nonatomic) NSUInteger propertyCount;
		[Export ("propertyCount")]
		nuint PropertyCount { get; }

		// @property (readonly, nonatomic) NSArray<RiveDataBindingViewModelInstancePropertyData *> * _Nonnull properties;
		[Export ("properties")]
		RiveDataBindingViewModelInstancePropertyData[] Properties { get; }

		// -(RiveDataBindingViewModelInstance * _Nullable)createInstanceFromIndex:(NSUInteger)index __attribute__((swift_name("createInstance(fromIndex:)")));
		[Export ("createInstanceFromIndex:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstance CreateInstanceFromIndex (nuint index);

		// -(RiveDataBindingViewModelInstance * _Nullable)createInstanceFromName:(NSString * _Nonnull)name __attribute__((swift_name("createInstance(fromName:)")));
		[Export ("createInstanceFromName:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstance CreateInstanceFromName (string name);

		// -(RiveDataBindingViewModelInstance * _Nullable)createDefaultInstance;
		[NullAllowed, Export ("createDefaultInstance")]
		// [Verify (MethodToProperty)]
		RiveDataBindingViewModelInstance CreateDefaultInstance { get; }

		// -(RiveDataBindingViewModelInstance * _Nullable)createInstance;
		[NullAllowed, Export ("createInstance")]
		// [Verify (MethodToProperty)]
		RiveDataBindingViewModelInstance CreateInstance { get; }
	}

	// @interface RiveDataBindingViewModelInstance : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveDataBindingViewModelInstance
	{
		// @property (readonly, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) NSUInteger propertyCount;
		[Export ("propertyCount")]
		nuint PropertyCount { get; }

		// @property (readonly, nonatomic) NSArray<RiveDataBindingViewModelInstancePropertyData *> * _Nonnull properties;
		[Export ("properties")]
		RiveDataBindingViewModelInstancePropertyData[] Properties { get; }

		// -(RiveDataBindingViewModelInstanceProperty * _Nullable)propertyFromPath:(NSString * _Nonnull)path;
		[Export ("propertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstanceProperty PropertyFromPath (string path);

		// -(RiveDataBindingViewModelInstanceStringProperty * _Nullable)stringPropertyFromPath:(NSString * _Nonnull)path;
		[Export ("stringPropertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstanceStringProperty StringPropertyFromPath (string path);

		// -(RiveDataBindingViewModelInstanceNumberProperty * _Nullable)numberPropertyFromPath:(NSString * _Nonnull)path;
		[Export ("numberPropertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstanceNumberProperty NumberPropertyFromPath (string path);

		// -(RiveDataBindingViewModelInstanceBooleanProperty * _Nullable)booleanPropertyFromPath:(NSString * _Nonnull)path;
		[Export ("booleanPropertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstanceBooleanProperty BooleanPropertyFromPath (string path);

		// -(RiveDataBindingViewModelInstanceColorProperty * _Nullable)colorPropertyFromPath:(NSString * _Nonnull)path;
		[Export ("colorPropertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstanceColorProperty ColorPropertyFromPath (string path);

		// -(RiveDataBindingViewModelInstanceEnumProperty * _Nullable)enumPropertyFromPath:(NSString * _Nonnull)path;
		[Export ("enumPropertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstanceEnumProperty EnumPropertyFromPath (string path);

		// -(RiveDataBindingViewModelInstance * _Nullable)viewModelInstancePropertyFromPath:(NSString * _Nonnull)path;
		[Export ("viewModelInstancePropertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstance ViewModelInstancePropertyFromPath (string path);

		// -(BOOL)setViewModelInstancePropertyFromPath:(NSString * _Nonnull)path toInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance __attribute__((swift_name("setViewModelInstanceProperty(fromPath:to:)")));
		[Export ("setViewModelInstancePropertyFromPath:toInstance:")]
		bool SetViewModelInstancePropertyFromPath (string path, RiveDataBindingViewModelInstance instance);

		// -(RiveDataBindingViewModelInstanceTriggerProperty * _Nullable)triggerPropertyFromPath:(NSString * _Nonnull)path;
		[Export ("triggerPropertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstanceTriggerProperty TriggerPropertyFromPath (string path);

		// -(RiveDataBindingViewModelInstanceImageProperty * _Nullable)imagePropertyFromPath:(NSString * _Nonnull)path;
		[Export ("imagePropertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstanceImageProperty ImagePropertyFromPath (string path);

		// -(RiveDataBindingViewModelInstanceListProperty * _Nullable)listPropertyFromPath:(NSString * _Nonnull)path;
		[Export ("listPropertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstanceListProperty ListPropertyFromPath (string path);

		// -(RiveDataBindingViewModelInstanceArtboardProperty * _Nullable)artboardPropertyFromPath:(NSString * _Nonnull)path;
		[Export ("artboardPropertyFromPath:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstanceArtboardProperty ArtboardPropertyFromPath (string path);

		// -(void)updateListeners;
		[Export ("updateListeners")]
		void UpdateListeners ();
	}

	// @interface RiveDataBindingViewModelInstanceProperty : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RiveDataBindingViewModelInstanceProperty
	{
		// @property (readonly, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) BOOL hasChanged;
		[Export ("hasChanged")]
		bool HasChanged { get; }

		// -(void)clearChanges;
		[Export ("clearChanges")]
		void ClearChanges ();

		// -(void)removeListener:(NSUUID * _Nonnull)listener;
		[Export ("removeListener:")]
		void RemoveListener (NSUuid listener);
	}

	// typedef void (^RiveDataBindingViewModelInstanceStringPropertyListener)(NSString * _Nonnull);
	delegate void RiveDataBindingViewModelInstanceStringPropertyListener (string arg0);

	// @interface RiveDataBindingViewModelInstanceStringProperty : RiveDataBindingViewModelInstanceProperty
	[BaseType (typeof(RiveDataBindingViewModelInstanceProperty))]
	[DisableDefaultCtor]
	interface RiveDataBindingViewModelInstanceStringProperty
	{
		// @property (copy, nonatomic) NSString * _Nonnull value;
		[Export ("value")]
		string Value { get; set; }

		// -(NSUUID * _Nonnull)addListener:(RiveDataBindingViewModelInstanceStringPropertyListener _Nonnull)listener;
		[Export ("addListener:")]
		NSUuid AddListener (RiveDataBindingViewModelInstanceStringPropertyListener listener);
	}

	// typedef void (^RiveDataBindingViewModelInstanceNumberPropertyListener)(float);
	delegate void RiveDataBindingViewModelInstanceNumberPropertyListener (float arg0);

	// @interface RiveDataBindingViewModelInstanceNumberProperty : RiveDataBindingViewModelInstanceProperty
	[BaseType (typeof(RiveDataBindingViewModelInstanceProperty))]
	[DisableDefaultCtor]
	interface RiveDataBindingViewModelInstanceNumberProperty
	{
		// @property (assign, nonatomic) float value;
		[Export ("value")]
		float Value { get; set; }

		// -(NSUUID * _Nonnull)addListener:(RiveDataBindingViewModelInstanceNumberPropertyListener _Nonnull)listener;
		[Export ("addListener:")]
		NSUuid AddListener (RiveDataBindingViewModelInstanceNumberPropertyListener listener);
	}

	// typedef void (^RiveDataBindingViewModelInstanceBooleanPropertyListener)(BOOL);
	delegate void RiveDataBindingViewModelInstanceBooleanPropertyListener (bool arg0);

	// @interface RiveDataBindingViewModelInstanceBooleanProperty : RiveDataBindingViewModelInstanceProperty
	[BaseType (typeof(RiveDataBindingViewModelInstanceProperty))]
	[DisableDefaultCtor]
	interface RiveDataBindingViewModelInstanceBooleanProperty
	{
		// @property (assign, nonatomic) BOOL value;
		[Export ("value")]
		bool Value { get; set; }

		// -(NSUUID * _Nonnull)addListener:(RiveDataBindingViewModelInstanceBooleanPropertyListener _Nonnull)listener;
		[Export ("addListener:")]
		NSUuid AddListener (RiveDataBindingViewModelInstanceBooleanPropertyListener listener);
	}

	// typedef void (^RiveDataBindingViewModelInstanceColorPropertyListener)(UIColor * _Nonnull);
	delegate void RiveDataBindingViewModelInstanceColorPropertyListener (UIColor arg0);

	// @interface RiveDataBindingViewModelInstanceColorProperty : RiveDataBindingViewModelInstanceProperty
	[BaseType (typeof(RiveDataBindingViewModelInstanceProperty))]
	[DisableDefaultCtor]
	interface RiveDataBindingViewModelInstanceColorProperty
	{
		// @property (copy, nonatomic) UIColor * _Nonnull value;
		[Export ("value", ArgumentSemantic.Copy)]
		UIColor Value { get; set; }

		// -(void)setRed:(CGFloat)red green:(CGFloat)green blue:(CGFloat)blue __attribute__((swift_name("set(red:green:blue:)")));
		[Export ("setRed:green:blue:")]
		void SetRed (nfloat red, nfloat green, nfloat blue);

		// -(void)setRed:(CGFloat)red green:(CGFloat)green blue:(CGFloat)blue alpha:(CGFloat)alpha __attribute__((swift_name("set(red:green:blue:alpha:)")));
		[Export ("setRed:green:blue:alpha:")]
		void SetRed (nfloat red, nfloat green, nfloat blue, nfloat alpha);

		// -(void)setAlpha:(CGFloat)alpha;
		[Export ("setAlpha:")]
		void SetAlpha (nfloat alpha);

		// -(NSUUID * _Nonnull)addListener:(RiveDataBindingViewModelInstanceColorPropertyListener _Nonnull)listener;
		[Export ("addListener:")]
		NSUuid AddListener (RiveDataBindingViewModelInstanceColorPropertyListener listener);
	}

	// typedef void (^RiveDataBindingViewModelInstanceEnumPropertyListener)(NSString * _Nonnull);
	delegate void RiveDataBindingViewModelInstanceEnumPropertyListener (string arg0);

	// @interface RiveDataBindingViewModelInstanceEnumProperty : RiveDataBindingViewModelInstanceProperty
	[BaseType (typeof(RiveDataBindingViewModelInstanceProperty))]
	[DisableDefaultCtor]
	interface RiveDataBindingViewModelInstanceEnumProperty
	{
		// @property (copy, nonatomic) NSString * _Nonnull value;
		[Export ("value")]
		string Value { get; set; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull values;
		[Export ("values")]
		string[] Values { get; }

		// @property (assign, nonatomic) int valueIndex;
		[Export ("valueIndex")]
		int ValueIndex { get; set; }

		// -(NSUUID * _Nonnull)addListener:(RiveDataBindingViewModelInstanceEnumPropertyListener _Nonnull)listener;
		[Export ("addListener:")]
		NSUuid AddListener (RiveDataBindingViewModelInstanceEnumPropertyListener listener);
	}

	// typedef void (^RiveDataBindingViewModelInstanceTriggerPropertyListener)();
	delegate void RiveDataBindingViewModelInstanceTriggerPropertyListener ();

	// @interface RiveDataBindingViewModelInstanceTriggerProperty : RiveDataBindingViewModelInstanceProperty
	[BaseType (typeof(RiveDataBindingViewModelInstanceProperty))]
	[DisableDefaultCtor]
	interface RiveDataBindingViewModelInstanceTriggerProperty
	{
		// -(void)trigger;
		[Export ("trigger")]
		void Trigger ();

		// -(NSUUID * _Nonnull)addListener:(RiveDataBindingViewModelInstanceTriggerPropertyListener _Nonnull)listener;
		[Export ("addListener:")]
		NSUuid AddListener (RiveDataBindingViewModelInstanceTriggerPropertyListener listener);
	}

	// typedef void (^RiveDataBindingViewModelInstanceImagePropertyListener)();
	delegate void RiveDataBindingViewModelInstanceImagePropertyListener ();

	// @interface RiveDataBindingViewModelInstanceImageProperty : RiveDataBindingViewModelInstanceProperty
	[BaseType (typeof(RiveDataBindingViewModelInstanceProperty))]
	[DisableDefaultCtor]
	interface RiveDataBindingViewModelInstanceImageProperty
	{
		// -(void)setValue:(RiveRenderImage * _Nullable)image;
		[Export ("setValue:")]
		void SetValue ([NullAllowed] RiveRenderImage image);

		// -(NSUUID * _Nonnull)addListener:(RiveDataBindingViewModelInstanceImagePropertyListener _Nonnull)listener;
		[Export ("addListener:")]
		NSUuid AddListener (RiveDataBindingViewModelInstanceImagePropertyListener listener);
	}

	// typedef void (^RiveDataBindingViewModelInstanceListPropertyListener)();
	delegate void RiveDataBindingViewModelInstanceListPropertyListener ();

	// @interface RiveDataBindingViewModelInstanceListProperty : RiveDataBindingViewModelInstanceProperty
	[BaseType (typeof(RiveDataBindingViewModelInstanceProperty))]
	[DisableDefaultCtor]
	interface RiveDataBindingViewModelInstanceListProperty
	{
		// @property (readonly, nonatomic) NSUInteger count;
		[Export ("count")]
		nuint Count { get; }

		// -(RiveDataBindingViewModelInstance * _Nullable)instanceAtIndex:(int)index __attribute__((swift_name("instance(at:)")));
		[Export ("instanceAtIndex:")]
		[return: NullAllowed]
		RiveDataBindingViewModelInstance InstanceAtIndex (int index);

		// -(void)addInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance __attribute__((swift_name("append(_:)")));
		[Export ("addInstance:")]
		void AddInstance (RiveDataBindingViewModelInstance instance);

		// -(BOOL)insertInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance atIndex:(int)index __attribute__((swift_name("insert(_:at:)")));
		[Export ("insertInstance:atIndex:")]
		bool InsertInstance (RiveDataBindingViewModelInstance instance, int index);

		// -(void)removeInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance __attribute__((swift_name("remove(_:)")));
		[Export ("removeInstance:")]
		void RemoveInstance (RiveDataBindingViewModelInstance instance);

		// -(void)removeInstanceAtIndex:(int)index __attribute__((swift_name("remove(at:)")));
		[Export ("removeInstanceAtIndex:")]
		void RemoveInstanceAtIndex (int index);

		// -(void)swapInstanceAtIndex:(uint32_t)firstIndex withInstanceAtIndex:(uint32_t)secondIndex __attribute__((swift_name("swap(at:with:)")));
		[Export ("swapInstanceAtIndex:withInstanceAtIndex:")]
		void SwapInstanceAtIndex (uint firstIndex, uint secondIndex);

		// -(NSUUID * _Nonnull)addListener:(RiveDataBindingViewModelInstanceListPropertyListener _Nonnull)listener;
		[Export ("addListener:")]
		NSUuid AddListener (RiveDataBindingViewModelInstanceListPropertyListener listener);
	}

	// typedef void (^RiveDataBindingViewModelInstanceArtboardPropertyListener)();
	delegate void RiveDataBindingViewModelInstanceArtboardPropertyListener ();

	// @interface RiveDataBindingViewModelInstanceArtboardProperty : RiveDataBindingViewModelInstanceProperty
	[BaseType (typeof(RiveDataBindingViewModelInstanceProperty))]
	[DisableDefaultCtor]
	interface RiveDataBindingViewModelInstanceArtboardProperty
	{
		// -(void)setValue:(RiveBindableArtboard * _Nullable)artboard;
		[Export ("setValue:")]
		void SetValue ([NullAllowed] RiveBindableArtboard artboard);

		// -(NSUUID * _Nonnull)addListener:(RiveDataBindingViewModelInstanceArtboardPropertyListener _Nonnull)listener;
		[Export ("addListener:")]
		NSUuid AddListener (RiveDataBindingViewModelInstanceArtboardPropertyListener listener);
	}

	// @interface RiveDataBindingViewModelInstancePropertyData : NSObject
	[BaseType (typeof(NSObject))]
	interface RiveDataBindingViewModelInstancePropertyData
	{
		// @property (readonly, nonatomic) RiveDataBindingViewModelInstancePropertyDataType type;
		[Export ("type")]
		RiveDataBindingViewModelInstancePropertyDataType Type { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }
	}

	// // @interface RiveRenderer : NSObject
	// [BaseType (typeof(NSObject))]
	// interface RiveRenderer
	// {
	// 	// -(instancetype _Nonnull)initWithContext:(CGContextRef _Nonnull)context;
	// 	[Export ("initWithContext:")]
	// 	NativeHandle Constructor (CGContext context);
	//
	// 	// -(void)alignWithRect:(CGRect)rect withContentRect:(CGRect)contentRect withAlignment:(RiveAlignment)alignment withFit:(RiveFit)fit;
	// 	[Export ("alignWithRect:withContentRect:withAlignment:withFit:")]
	// 	void AlignWithRect (CGRect rect, CGRect contentRect, RiveAlignment alignment, RiveFit fit);
	// }

	// @protocol RiveMetalDrawableView
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface RiveMetalDrawableView
	{
		// @required @property (retain, nonatomic) id<MTLDevice> _Nullable device;
		[Abstract]
		[NullAllowed, Export ("device", ArgumentSemantic.Retain)]
		IMTLDevice Device { get; set; }

		// @required @property (nonatomic) MTLPixelFormat depthStencilPixelFormat;
		[Abstract]
		[Export ("depthStencilPixelFormat", ArgumentSemantic.Assign)]
		MTLPixelFormat DepthStencilPixelFormat { get; set; }

		// @required @property (nonatomic) BOOL framebufferOnly;
		[Abstract]
		[Export ("framebufferOnly")]
		bool FramebufferOnly { get; set; }

		// @required @property (nonatomic) NSUInteger sampleCount;
		[Abstract]
		[Export ("sampleCount")]
		nuint SampleCount { get; set; }

		// @required @property (nonatomic) BOOL enableSetNeedsDisplay;
		[Abstract]
		[Export ("enableSetNeedsDisplay")]
		bool EnableSetNeedsDisplay { get; set; }

		// @required @property (getter = isPaused, nonatomic) BOOL paused;
		[Abstract]
		[Export ("paused")]
		bool Paused { [Bind ("isPaused")] get; set; }

		// // @required @property (readonly, nonatomic) id<CAMetalDrawable> _Nullable currentDrawable;
		// [Abstract]
		// [NullAllowed, Export ("currentDrawable")]
		// ICAMetalDrawable CurrentDrawable { get; }

		// @required @property (nonatomic) MTLPixelFormat colorPixelFormat;
		[Abstract]
		[Export ("colorPixelFormat", ArgumentSemantic.Assign)]
		MTLPixelFormat ColorPixelFormat { get; set; }

		// @required @property (nonatomic) CGSize drawableSize;
		[Abstract]
		[Export ("drawableSize", ArgumentSemantic.Assign)]
		CGSize DrawableSize { get; set; }

		// @required -(void)drawableSizeDidChange:(CGSize)drawableSize;
		[Abstract]
		[Export ("drawableSizeDidChange:")]
		void DrawableSizeDidChange (CGSize drawableSize);
	}

	// @interface RiveMTKView : MTKView <RiveMetalDrawableView>
	[BaseType (typeof(MTKView))]
	interface RiveMTKView : RiveMetalDrawableView
	{
	}

	// @interface RiveRendererView : RiveMTKView
	[BaseType (typeof(RiveMTKView))]
	interface RiveRendererView
	{
		// // @property (nonatomic, strong) id<CAMetalDrawable> _Nullable currentDrawableOverride;
		// [NullAllowed, Export ("currentDrawableOverride", ArgumentSemantic.Strong)]
		// ICAMetalDrawable CurrentDrawableOverride { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frameRect;
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frameRect);

		// -(void)alignWithRect:(CGRect)rect contentRect:(CGRect)contentRect alignment:(RiveAlignment)alignment fit:(RiveFit)fit __attribute__((deprecated("Use alignWithRect:contentRect:alignment:fit:scaleFactor: instead.")));
		[Export ("alignWithRect:contentRect:alignment:fit:")]
		void AlignWithRect (CGRect rect, CGRect contentRect, RiveAlignment alignment, RiveFit fit);

		// -(void)alignWithRect:(CGRect)rect contentRect:(CGRect)contentRect alignment:(RiveAlignment)alignment fit:(RiveFit)fit scaleFactor:(CGFloat)scaleFactor;
		[Export ("alignWithRect:contentRect:alignment:fit:scaleFactor:")]
		void AlignWithRect (CGRect rect, CGRect contentRect, RiveAlignment alignment, RiveFit fit, nfloat scaleFactor);

		// -(void)save;
		[Export ("save")]
		void Save ();

		// -(void)restore;
		[Export ("restore")]
		void Restore ();

		// -(void)transform:(float)xx xy:(float)xy yx:(float)yx yy:(float)yy tx:(float)tx ty:(float)ty;
		[Export ("transform:xy:yx:yy:tx:ty:")]
		void Transform (float xx, float xy, float yx, float yy, float tx, float ty);

		// -(void)drawWithArtboard:(RiveArtboard * _Nonnull)artboard;
		[Export ("drawWithArtboard:")]
		void DrawWithArtboard (RiveArtboard artboard);

		// -(void)drawRive:(CGRect)rect size:(CGSize)size;
		[Export ("drawRive:size:")]
		void DrawRive (CGRect rect, CGSize size);

		// -(void)drawInRect:(CGRect)rect withCompletion:(MTLCommandBufferHandler _Nullable)completionHandler;
		[Export ("drawInRect:withCompletion:")]
		void DrawInRect (CGRect rect, [NullAllowed] Action<IMTLCommandBuffer> completionHandler);
		// void DrawInRect (CGRect rect, [NullAllowed] MTLCommandBufferHandler completionHandler);

		// -(_Bool)isPaused;
		[Export ("isPaused")]
		// [Verify (MethodToProperty)]
		bool IsPaused { get; }

		// -(CGPoint)artboardLocationFromTouchLocation:(CGPoint)touchLocation inArtboard:(CGRect)artboardRect fit:(RiveFit)fit alignment:(RiveAlignment)alignment;
		[Export ("artboardLocationFromTouchLocation:inArtboard:fit:alignment:")]
		CGPoint ArtboardLocationFromTouchLocation (CGPoint touchLocation, CGRect artboardRect, RiveFit fit, RiveAlignment alignment);
	}

	// // @interface FPSCounterView : UILabel
	// [BaseType (typeof(UILabel), Name = "_TtC11RiveRuntime14FPSCounterView")]
	// interface FPSCounterView
	// {
	// 	// // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
	// 	// [Export ("initWithFrame:")]
	// 	// [DesignatedInitializer]
	// 	// NativeHandle Constructor (CGRect frame);
	// 	//
	// 	// // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
	// 	// [Export ("initWithCoder:")]
	// 	// [DesignatedInitializer]
	// 	// NativeHandle Constructor (NSCoder coder);
	// }

	// @interface RiveFallbackFontDescriptor : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11RiveRuntime26RiveFallbackFontDescriptor")]
	[DisableDefaultCtor]
	interface RiveFallbackFontDescriptor
	{
		// -(instancetype _Nonnull)initWithDesign:(enum RiveFallbackFontDescriptorDesign)design weight:(enum RiveFallbackFontDescriptorWeight)weight width:(enum RiveFallbackFontDescriptorWidth)width __attribute__((objc_designated_initializer));
		[Export ("initWithDesign:weight:width:")]
		[DesignatedInitializer]
		NativeHandle Constructor (RiveFallbackFontDescriptorDesign design, RiveFallbackFontDescriptorWeight weight, RiveFallbackFontDescriptorWidth width);
	}

	// @interface RiveRuntime_Swift_349 (RiveFallbackFontDescriptor) <RiveFallbackFontProvider>
	[Category]
	[BaseType (typeof(RiveFallbackFontDescriptor))]
	interface RiveFallbackFontDescriptor_RiveRuntime_Swift_349
	{
		// @property (readonly, nonatomic, strong) UIFont * _Nonnull fallbackFont;
		[Export ("fallbackFont", ArgumentSemantic.Strong)]
		// UIFont FallbackFont { get; }
		UIFont GetFallbackFont (RiveFallbackFontDescriptor self);
	}

	// @protocol RiveFontWidthProvider
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP11RiveRuntime21RiveFontWidthProvider_")]
	// [Protocol]
	interface RiveFontWidthProvider
	{
		// @required @property (readonly, nonatomic) NSInteger riveFontWidthValue;
		[Abstract]
		[Export ("riveFontWidthValue")]
		nint RiveFontWidthValue { get; }
	}

	// @interface RiveLogCategory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11RiveRuntime15RiveLogCategory")]
	[DisableDefaultCtor]
	interface RiveLogCategory
	{
		// @property (readonly, nonatomic, strong, class) RiveLogCategory * _Nonnull stateMachine;
		[Static]
		[Export ("stateMachine", ArgumentSemantic.Strong)]
		RiveLogCategory StateMachine { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogCategory * _Nonnull artboard;
		[Static]
		[Export ("artboard", ArgumentSemantic.Strong)]
		RiveLogCategory Artboard { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogCategory * _Nonnull viewModel;
		[Static]
		[Export ("viewModel", ArgumentSemantic.Strong)]
		RiveLogCategory ViewModel { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogCategory * _Nonnull model;
		[Static]
		[Export ("model", ArgumentSemantic.Strong)]
		RiveLogCategory Model { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogCategory * _Nonnull file;
		[Static]
		[Export ("file", ArgumentSemantic.Strong)]
		RiveLogCategory File { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogCategory * _Nonnull view;
		[Static]
		[Export ("view", ArgumentSemantic.Strong)]
		RiveLogCategory View { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogCategory * _Nonnull dataBinding;
		[Static]
		[Export ("dataBinding", ArgumentSemantic.Strong)]
		RiveLogCategory DataBinding { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogCategory * _Nonnull none;
		[Static]
		[Export ("none", ArgumentSemantic.Strong)]
		RiveLogCategory None { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogCategory * _Nonnull all;
		[Static]
		[Export ("all", ArgumentSemantic.Strong)]
		RiveLogCategory All { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }
	}

	// @interface RiveLogLevel : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11RiveRuntime12RiveLogLevel")]
	[DisableDefaultCtor]
	interface RiveLogLevel
	{
		// @property (readonly, nonatomic, strong, class) RiveLogLevel * _Nonnull debug;
		[Static]
		[Export ("debug", ArgumentSemantic.Strong)]
		RiveLogLevel Debug { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogLevel * _Nonnull info;
		[Static]
		[Export ("info", ArgumentSemantic.Strong)]
		RiveLogLevel Info { get; }

		// @property (readonly, getter = default, nonatomic, strong, class) RiveLogLevel * _Nonnull default_;
		[Static]
		[Export ("default_", ArgumentSemantic.Strong)]
		RiveLogLevel Default_ { [Bind ("default")] get; }

		// @property (readonly, nonatomic, strong, class) RiveLogLevel * _Nonnull error;
		[Static]
		[Export ("error", ArgumentSemantic.Strong)]
		RiveLogLevel Error { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogLevel * _Nonnull fault;
		[Static]
		[Export ("fault", ArgumentSemantic.Strong)]
		RiveLogLevel Fault { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogLevel * _Nonnull none;
		[Static]
		[Export ("none", ArgumentSemantic.Strong)]
		RiveLogLevel None { get; }

		// @property (readonly, nonatomic, strong, class) RiveLogLevel * _Nonnull all;
		[Static]
		[Export ("all", ArgumentSemantic.Strong)]
		RiveLogLevel All { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }
	}

	// @interface RiveLogger : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11RiveRuntime10RiveLogger")]
	interface RiveLogger
	{
		// @property (nonatomic, class) BOOL isEnabled;
		[Static]
		[Export ("isEnabled")]
		bool IsEnabled { get; set; }

		// @property (nonatomic, class) BOOL isVerbose;
		[Static]
		[Export ("isVerbose")]
		bool IsVerbose { get; set; }

		// @property (nonatomic, strong, class) RiveLogLevel * _Nonnull levels;
		[Static]
		[Export ("levels", ArgumentSemantic.Strong)]
		RiveLogLevel Levels { get; set; }

		// @property (nonatomic, strong, class) RiveLogCategory * _Nonnull categories;
		[Static]
		[Export ("categories", ArgumentSemantic.Strong)]
		RiveLogCategory Categories { get; set; }
	}

	// @interface RiveRuntime_Swift_511 (RiveLogger)
	[Category]
	[BaseType (typeof(RiveLogger))]
	interface RiveLogger_RiveRuntime_Swift_511
	{
		// +(void)logArtboard:(RiveArtboard * _Nonnull)artboard advance:(double)advance;
		[Static]
		[Export ("logArtboard:advance:")]
		void LogArtboard (RiveArtboard artboard, double advance);

		// +(void)logArtboard:(RiveArtboard * _Nonnull)artboard error:(NSString * _Nonnull)error;
		[Static]
		[Export ("logArtboard:error:")]
		void LogArtboardWithError (RiveArtboard artboard, string error);

		// +(void)logArtboard:(RiveArtboard * _Nonnull)artboard instanceBind:(NSString * _Nonnull)name;
		[Static]
		[Export ("logArtboard:instanceBind:")]
		void LogArtboardWithInstanceBind (RiveArtboard artboard, string name);
	}

	// @interface RiveRuntime_Swift_519 (RiveLogger)
	[Category]
	[BaseType (typeof(RiveLogger))]
	interface RiveLogger_RiveRuntime_Swift_519
	{
		// +(void)logStateMachine:(RiveStateMachineInstance * _Nonnull)stateMachine advance:(double)advance;
		[Static]
		[Export ("logStateMachine:advance:")]
		void LogStateMachine (RiveStateMachineInstance stateMachine, double advance);

		// +(void)logStateMachine:(RiveStateMachineInstance * _Nonnull)stateMachine error:(NSString * _Nonnull)error;
		[Static]
		[Export ("logStateMachine:error:")]
		void LogStateMachineWithError (RiveStateMachineInstance stateMachine, string error);

		// +(void)logStateMachine:(RiveStateMachineInstance * _Nonnull)stateMachine instanceBind:(NSString * _Nonnull)name;
		[Static]
		[Export ("logStateMachine:instanceBind:")]
		void LogStateMachineWithInstanceBind (RiveStateMachineInstance stateMachine, string name);
	}

	// @interface RiveRuntime_Swift_531 (RiveLogger)
	[Category]
	[BaseType (typeof(RiveLogger))]
	interface RiveLogger_RiveRuntime_Swift_531
	{
		// +(void)logFile:(RiveFile * _Nullable)file error:(NSString * _Nonnull)message;
		[Static]
		[Export ("logFile:error:")]
		void LogFile ([NullAllowed] RiveFile file, string message);

		// +(void)logLoadingAsset:(RiveFileAsset * _Nonnull)asset;
		[Static]
		[Export ("logLoadingAsset:")]
		void LogLoadingAsset (RiveFileAsset asset);

		// +(void)logFontAssetLoad:(RiveFontAsset * _Nonnull)fontAsset fromURL:(NSURL * _Nonnull)url;
		[Static]
		[Export ("logFontAssetLoad:fromURL:")]
		void LogFontAssetLoad (RiveFontAsset fontAsset, NSUrl url);

		// +(void)logImageAssetLoad:(RiveImageAsset * _Nonnull)imageAsset fromURL:(NSURL * _Nonnull)url;
		[Static]
		[Export ("logImageAssetLoad:fromURL:")]
		void LogImageAssetLoad (RiveImageAsset imageAsset, NSUrl url);

		// +(void)logAssetLoaded:(RiveFileAsset * _Nonnull)asset;
		[Static]
		[Export ("logAssetLoaded:")]
		void LogAssetLoaded (RiveFileAsset asset);

		// +(void)logLoadedFromURL:(NSURL * _Nonnull)url;
		[Static]
		[Export ("logLoadedFromURL:")]
		void LogLoadedFromURL (NSUrl url);

		// +(void)logLoadingFromResource:(NSString * _Nonnull)name;
		[Static]
		[Export ("logLoadingFromResource:")]
		void LogLoadingFromResource (string name);

		// +(void)logFileViewModelWithName:(NSString * _Nonnull)name found:(BOOL)found;
		[Static]
		[Export ("logFileViewModelWithName:found:")]
		void LogFileViewModelWithName (string name, bool found);

		// +(void)logFileViewModelAtIndex:(NSInteger)index found:(BOOL)found;
		[Static]
		[Export ("logFileViewModelAtIndex:found:")]
		void LogFileViewModelAtIndex (nint index, bool found);

		// +(void)logFileDefaultViewModelForArtboard:(RiveArtboard * _Nonnull)artboard found:(BOOL)found;
		[Static]
		[Export ("logFileDefaultViewModelForArtboard:found:")]
		void LogFileDefaultViewModelForArtboard (RiveArtboard artboard, bool found);
	}

	// @interface RiveRuntime_Swift_548 (RiveLogger)
	[Category]
	[BaseType (typeof(RiveLogger))]
	interface RiveLogger_RiveRuntime_Swift_548
	{
		// +(void)logWithViewModelRuntime:(RiveDataBindingViewModel * _Nonnull)runtime createdInstanceFromIndex:(NSInteger)index created:(BOOL)created;
		[Static]
		[Export ("logWithViewModelRuntime:createdInstanceFromIndex:created:")]
		void LogWithViewModelRuntime (RiveDataBindingViewModel runtime, nint index, bool created);

		// +(void)logWithViewModelRuntime:(RiveDataBindingViewModel * _Nonnull)runtime createdInstanceFromName:(NSString * _Nonnull)name created:(BOOL)created;
		[Static]
		[Export ("logWithViewModelRuntime:createdInstanceFromName:created:")]
		void LogWithViewModelRuntime (RiveDataBindingViewModel runtime, string name, bool created);

		// +(void)logViewModelRuntimeCreatedDefaultInstance:(RiveDataBindingViewModel * _Nonnull)runtime created:(BOOL)created;
		[Static]
		[Export ("logViewModelRuntimeCreatedDefaultInstance:created:")]
		void LogViewModelRuntimeCreatedDefaultInstance (RiveDataBindingViewModel runtime, bool created);

		// +(void)logViewModelRuntimeCreatedInstance:(RiveDataBindingViewModel * _Nonnull)runtime created:(BOOL)created;
		[Static]
		[Export ("logViewModelRuntimeCreatedInstance:created:")]
		void LogViewModelRuntimeCreatedInstance (RiveDataBindingViewModel runtime, bool created);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance propertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:propertyAtPath:found:")]
		void LogWithViewModelInstanceWithPropPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance stringPropertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:stringPropertyAtPath:found:")]
		void LogWithViewModelInstanceWithStrPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance numberPropertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:numberPropertyAtPath:found:")]
		void LogWithViewModelInstanceWithNumPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance booleanPropertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:booleanPropertyAtPath:found:")]
		void LogWithViewModelInstanceWithBoolPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance colorPropertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:colorPropertyAtPath:found:")]
		void LogWithViewModelInstanceWithColorPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance enumPropertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:enumPropertyAtPath:found:")]
		void LogWithViewModelInstanceWithEnumPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance viewModelPropertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:viewModelPropertyAtPath:found:")]
		void LogWithViewModelInstanceWithVmPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance triggerPropertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:triggerPropertyAtPath:found:")]
		void LogWithViewModelInstanceWithTrigPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance imagePropertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:imagePropertyAtPath:found:")]
		void LogWithViewModelInstanceWithImgPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance listPropertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:listPropertyAtPath:found:")]
		void LogWithViewModelInstanceWithListPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logWithViewModelInstance:(RiveDataBindingViewModelInstance * _Nonnull)instance artboardPropertyAtPath:(NSString * _Nonnull)path found:(BOOL)found;
		[Static]
		[Export ("logWithViewModelInstance:artboardPropertyAtPath:found:")]
		void LogWithViewModelInstanceWithArtPath (RiveDataBindingViewModelInstance instance, string path, bool found);

		// +(void)logPropertyUpdated:(RiveDataBindingViewModelInstanceProperty * _Nonnull)property value:(NSString * _Nonnull)value;
		[Static]
		[Export ("logPropertyUpdated:value:")]
		void LogPropertyUpdated (RiveDataBindingViewModelInstanceProperty property, string value);

		// +(void)logPropertyTriggered:(RiveDataBindingViewModelInstanceProperty * _Nonnull)property;
		[Static]
		[Export ("logPropertyTriggered:")]
		void LogPropertyTriggered (RiveDataBindingViewModelInstanceProperty property);
	}

	// @interface RiveModel : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11RiveRuntime9RiveModel")]
	[DisableDefaultCtor]
	interface RiveModel
	{
		// -(instancetype _Nonnull)initWithRiveFile:(RiveFile * _Nonnull)riveFile __attribute__((objc_designated_initializer));
		[Export ("initWithRiveFile:")]
		[DesignatedInitializer]
		NativeHandle Constructor (RiveFile riveFile);

		// -(instancetype _Nullable)initWithFileName:(NSString * _Nonnull)fileName extension:(NSString * _Nonnull)extension in:(NSBundle * _Nonnull)bundle loadCdn:(BOOL)loadCdn error:(NSError * _Nullable * _Nullable)error customLoader:(LoadAsset _Nullable)customLoader __attribute__((objc_designated_initializer));
		[Export ("initWithFileName:extension:in:loadCdn:error:customLoader:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string fileName, string extension, NSBundle bundle, bool loadCdn, [NullAllowed] out NSError error, [NullAllowed] LoadAsset customLoader);

		// -(instancetype _Nonnull)initWithWebURL:(NSString * _Nonnull)webURL delegate:(id<RiveFileDelegate> _Nonnull)delegate loadCdn:(BOOL)loadCdn __attribute__((objc_designated_initializer));
		[Export ("initWithWebURL:delegate:loadCdn:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string webURL, RiveFileDelegate @delegate, bool loadCdn);

		// @property (nonatomic) float volume;
		[Export ("volume")]
		float Volume { get; set; }

		// -(BOOL)setArtboard:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
		[Export ("setArtboard:error:")]
		bool SetArtboard (string name, [NullAllowed] out NSError error);

		// -(BOOL)setStateMachine:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
		[Export ("setStateMachine:error:")]
		bool SetStateMachine (string name, [NullAllowed] out NSError error);

		// -(BOOL)setAnimation:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
		[Export ("setAnimation:error:")]
		bool SetAnimation (string name, [NullAllowed] out NSError error);

		// -(void)enableAutoBind:(void (^ _Nonnull)(RiveDataBindingViewModelInstance * _Nonnull))callback;
		[Export ("enableAutoBind:")]
		void EnableAutoBind (Action<RiveDataBindingViewModelInstance> callback);

		// -(void)disableAutoBind;
		[Export ("disableAutoBind")]
		void DisableAutoBind ();

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @protocol RivePlayerDelegate
	[Protocol (Name = "_TtP11RiveRuntime18RivePlayerDelegate_"), Model]
	[BaseType(typeof(NSObject))]
	interface RivePlayerDelegate
	{
		// @required -(void)playerWithPlayedWithModel:(RiveModel * _Nullable)riveModel;
		[Abstract]
		[Export ("playerWithPlayedWithModel:")]
		void PlayerWithPlayedWithModel ([NullAllowed] RiveModel riveModel);

		// @required -(void)playerWithPausedWithModel:(RiveModel * _Nullable)riveModel;
		[Abstract]
		[Export ("playerWithPausedWithModel:")]
		void PlayerWithPausedWithModel ([NullAllowed] RiveModel riveModel);

		// @required -(void)playerWithLoopedWithModel:(RiveModel * _Nullable)riveModel type:(NSInteger)type;
		[Abstract]
		[Export ("playerWithLoopedWithModel:type:")]
		void PlayerWithLoopedWithModel ([NullAllowed] RiveModel riveModel, nint type);

		// @required -(void)playerWithStoppedWithModel:(RiveModel * _Nullable)riveModel;
		[Abstract]
		[Export ("playerWithStoppedWithModel:")]
		void PlayerWithStoppedWithModel ([NullAllowed] RiveModel riveModel);

		// @required -(void)playerWithDidAdvanceby:(double)seconds riveModel:(RiveModel * _Nullable)riveModel;
		[Abstract]
		[Export ("playerWithDidAdvanceby:riveModel:")]
		void PlayerWithDidAdvanceby (double seconds, [NullAllowed] RiveModel riveModel);
	}

	// @protocol RiveStateMachineDelegate
	[Protocol (Name = "_TtP11RiveRuntime24RiveStateMachineDelegate_"), Model]
	[BaseType(typeof(NSObject))]
	interface RiveStateMachineDelegate
	{
		// @optional -(void)touchBeganOnArtboard:(RiveArtboard * _Nullable)artboard atLocation:(CGPoint)location;
		[Export ("touchBeganOnArtboard:atLocation:")]
		void TouchBeganOnArtboard ([NullAllowed] RiveArtboard artboard, CGPoint location);

		// @optional -(void)touchMovedOnArtboard:(RiveArtboard * _Nullable)artboard atLocation:(CGPoint)location;
		[Export ("touchMovedOnArtboard:atLocation:")]
		void TouchMovedOnArtboard ([NullAllowed] RiveArtboard artboard, CGPoint location);

		// @optional -(void)touchEndedOnArtboard:(RiveArtboard * _Nullable)artboard atLocation:(CGPoint)location;
		[Export ("touchEndedOnArtboard:atLocation:")]
		void TouchEndedOnArtboard ([NullAllowed] RiveArtboard artboard, CGPoint location);

		// @optional -(void)touchCancelledOnArtboard:(RiveArtboard * _Nullable)artboard atLocation:(CGPoint)location;
		[Export ("touchCancelledOnArtboard:atLocation:")]
		void TouchCancelledOnArtboard ([NullAllowed] RiveArtboard artboard, CGPoint location);

		// @optional -(void)touchExitedOnArtboard:(RiveArtboard * _Nullable)artboard atLocation:(CGPoint)location;
		[Export ("touchExitedOnArtboard:atLocation:")]
		void TouchExitedOnArtboard ([NullAllowed] RiveArtboard artboard, CGPoint location);

		// @optional -(void)stateMachine:(RiveStateMachineInstance * _Nonnull)stateMachine receivedInput:(StateMachineInput * _Nonnull)input;
		[Export ("stateMachine:receivedInput:")]
		void StateMachine (RiveStateMachineInstance stateMachine, StateMachineInput input);

		// @optional -(void)stateMachine:(RiveStateMachineInstance * _Nonnull)stateMachine didChangeState:(NSString * _Nonnull)stateName;
		[Export ("stateMachine:didChangeState:")]
		void StateMachine (RiveStateMachineInstance stateMachine, string stateName);

		// @optional -(void)stateMachine:(RiveStateMachineInstance * _Nonnull)stateMachine didReceiveHitResult:(RiveHitResult)hitResult from:(enum RiveTouchEvent)event;
		[Export ("stateMachine:didReceiveHitResult:from:")]
		void StateMachine (RiveStateMachineInstance stateMachine, RiveHitResult hitResult, RiveTouchEvent @event);

		// @optional -(void)onRiveEventReceivedOnRiveEvent:(RiveEvent * _Nonnull)riveEvent;
		[Export ("onRiveEventReceivedOnRiveEvent:")]
		void OnRiveEventReceivedOnRiveEvent (RiveEvent riveEvent);
	}

	// @interface RiveRuntime_Swift_629 (RiveStateMachineInstance)
	[Category]
	[BaseType (typeof(RiveStateMachineInstance))]
	interface RiveStateMachineInstance_RiveRuntime_Swift_629
	{
		// @property (readonly, copy, nonatomic) NSArray<StateMachineInput *> * _Nonnull inputs;
		[Export ("inputs", ArgumentSemantic.Copy)]
		// StateMachineInput[] Inputs { get; }
		StateMachineInput[] GetInputs(RiveStateMachineInstance self);
	}

	// @interface RiveView : RiveRendererView
	[BaseType (typeof(RiveRendererView), Name = "_TtC11RiveRuntime8RiveView")]
	interface RiveView
	{
		[Wrap ("WeakPlayerDelegate")]
		[NullAllowed]
		RivePlayerDelegate PlayerDelegate { get; set; }

		// @property (nonatomic, weak) id<RivePlayerDelegate> _Nullable playerDelegate;
		[NullAllowed, Export ("playerDelegate", ArgumentSemantic.Weak)]
		NSObject WeakPlayerDelegate { get; set; }
		
		[Export("stateMachineDelegate", ArgumentSemantic.Weak)] 
		[NullAllowed]
		NSObject WeakStateMachineDelegate { get; set; }
		
		[Wrap("WeakStateMachineDelegate")] 
		[NullAllowed]
		RiveStateMachineDelegate stateMachineDelegate { get; set; }

		// @property (nonatomic) CGRect bounds;
		[Export ("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// @property (nonatomic) CGRect frame;
		[Export ("frame", ArgumentSemantic.Assign)]
		CGRect Frame { get; set; }

		// // -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(BOOL)setModel:(RiveModel * _Nonnull)model autoPlay:(BOOL)autoPlay error:(NSError * _Nullable * _Nullable)error;
		[Export ("setModel:autoPlay:error:")]
		bool SetModel (RiveModel model, bool autoPlay, [NullAllowed] out NSError error);

		// -(void)setPreferredFPS:(NSInteger)preferredFramesPerSecond;
		[Export ("setPreferredFPS:")]
		void SetPreferredFPS (nint preferredFramesPerSecond);

		// // -(void)setPreferredFrameRateRange:(CAFrameRateRange)preferredFrameRateRange __attribute__((availability(visionos, introduced=1))) __attribute__((availability(tvos, introduced=15))) __attribute__((availability(macos, introduced=14))) __attribute__((availability(ios, introduced=15)));
		// // [Introduced (PlatformName.VisionOS, 1, 0)]
		// [TV (15,0), Mac (14,0), iOS (15,0)]
		// [Export ("setPreferredFrameRateRange:")]
		// void SetPreferredFrameRateRange (CAFrameRateRange preferredFrameRateRange);

		// -(void)advanceWithDelta:(double)delta;
		[Export ("advanceWithDelta:")]
		void AdvanceWithDelta (double delta);

		// -(void)drawRive:(CGRect)rect size:(CGSize)size;
		[Export ("drawRive:size:")]
		void DrawRive (CGRect rect, CGSize size);

		// -(void)drawRect:(CGRect)rect;
		[Export ("drawRect:")]
		void DrawRect (CGRect rect);

		// -(void)drawableSizeDidChange:(CGSize)drawableSize;
		[Export ("drawableSizeDidChange:")]
		void DrawableSizeDidChange (CGSize drawableSize);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesBegan:withEvent:")]
		void TouchesBegan (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesMoved:withEvent:")]
		void TouchesMoved (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesEnded:withEvent:")]
		void TouchesEnded (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesCancelled:withEvent:")]
		void TouchesCancelled (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);
	}

	// @interface RiveViewModel : NSObject <RiveFileDelegate, RivePlayerDelegate, RiveStateMachineDelegate>
	[BaseType (typeof(NSObject), Name = "_TtC11RiveRuntime13RiveViewModel")]
	[DisableDefaultCtor]
	interface RiveViewModel : RiveFileDelegate, RivePlayerDelegate, RiveStateMachineDelegate
	{
		// @property (readonly, nonatomic, class) double layoutScaleFactorAutomatic;
		[Static]
		[Export ("layoutScaleFactorAutomatic")]
		double LayoutScaleFactorAutomatic { get; }

		// -(instancetype _Nonnull)init:(RiveModel * _Nonnull)model stateMachineName:(NSString * _Nullable)stateMachineName fit:(RiveFit)fit alignment:(RiveAlignment)alignment autoPlay:(BOOL)autoPlay artboardName:(NSString * _Nullable)artboardName __attribute__((objc_designated_initializer));
		[Export ("init:stateMachineName:fit:alignment:autoPlay:artboardName:")]
		[DesignatedInitializer]
		NativeHandle Constructor (RiveModel model, [NullAllowed] string stateMachineName, RiveFit fit, RiveAlignment alignment, bool autoPlay, [NullAllowed] string artboardName);

		// -(instancetype _Nonnull)init:(RiveModel * _Nonnull)model animationName:(NSString * _Nullable)animationName fit:(RiveFit)fit alignment:(RiveAlignment)alignment autoPlay:(BOOL)autoPlay artboardName:(NSString * _Nullable)artboardName __attribute__((objc_designated_initializer));
		[Export ("init:animationName:fit:alignment:autoPlay:artboardName:")]
		[DesignatedInitializer]
		NativeHandle Constructor (RiveModel model, [NullAllowed] NSString animationName, RiveFit fit, RiveAlignment alignment, bool autoPlay, [NullAllowed] string artboardName);

		// -(instancetype _Nonnull)initWithFileName:(NSString * _Nonnull)fileName extension:(NSString * _Nonnull)extension in:(NSBundle * _Nonnull)bundle stateMachineName:(NSString * _Nullable)stateMachineName fit:(RiveFit)fit alignment:(RiveAlignment)alignment autoPlay:(BOOL)autoPlay artboardName:(NSString * _Nullable)artboardName loadCdn:(BOOL)loadCdn customLoader:(LoadAsset _Nullable)customLoader __attribute__((objc_designated_initializer));
		[Export ("initWithFileName:extension:in:stateMachineName:fit:alignment:autoPlay:artboardName:loadCdn:customLoader:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string fileName, string extension, NSBundle bundle, [NullAllowed] string stateMachineName, RiveFit fit, RiveAlignment alignment, bool autoPlay, [NullAllowed] string artboardName, bool loadCdn, [NullAllowed] LoadAsset customLoader);

		// -(instancetype _Nonnull)initWithWebURL:(NSString * _Nonnull)webURL stateMachineName:(NSString * _Nullable)stateMachineName fit:(RiveFit)fit alignment:(RiveAlignment)alignment autoPlay:(BOOL)autoPlay loadCdn:(BOOL)loadCdn artboardName:(NSString * _Nullable)artboardName __attribute__((objc_designated_initializer));
		[Export ("initWithWebURL:stateMachineName:fit:alignment:autoPlay:loadCdn:artboardName:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string webURL, [NullAllowed] string stateMachineName, RiveFit fit, RiveAlignment alignment, bool autoPlay, bool loadCdn, [NullAllowed] string artboardName);

		// -(instancetype _Nonnull)initWithWebURL:(NSString * _Nonnull)webURL animationName:(NSString * _Nullable)animationName fit:(RiveFit)fit alignment:(RiveAlignment)alignment autoPlay:(BOOL)autoPlay loadCdn:(BOOL)loadCdn artboardName:(NSString * _Nullable)artboardName __attribute__((objc_designated_initializer));
		[Export ("initWithWebURL:animationName:fit:alignment:autoPlay:loadCdn:artboardName:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string webURL, [NullAllowed] NSString animationName, RiveFit fit, RiveAlignment alignment, bool autoPlay, bool loadCdn, [NullAllowed] string artboardName);

		// @property (readonly, nonatomic, strong) RiveModel * _Nullable riveModel;
		[NullAllowed, Export ("riveModel", ArgumentSemantic.Strong)]
		RiveModel RiveModel { get; }

		// @property (readonly, nonatomic) BOOL isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }

		// @property (nonatomic) BOOL autoPlay;
		[Export ("autoPlay")]
		bool AutoPlay { get; set; }

		// @property (nonatomic) RiveFit fit;
		[Export ("fit", ArgumentSemantic.Assign)]
		RiveFit Fit { get; set; }

		// @property (nonatomic) RiveAlignment alignment;
		[Export ("alignment", ArgumentSemantic.Assign)]
		RiveAlignment Alignment { get; set; }

		// @property (nonatomic) double layoutScaleFactor;
		[Export ("layoutScaleFactor")]
		double LayoutScaleFactor { get; set; }

		// @property (nonatomic) BOOL forwardsListenerEvents;
		[Export ("forwardsListenerEvents")]
		bool ForwardsListenerEvents { get; set; }

		// // -(void)setPreferredFramesPerSecond:(NSInteger)preferredFramesPerSecond;
		// [Export ("setPreferredFramesPerSecond:")]
		// void SetPreferredFramesPerSecond (nint preferredFramesPerSecond);

		// // -(void)setPreferredFrameRateRange:(CAFrameRateRange)preferredFrameRateRange __attribute__((availability(visionos, introduced=1.0))) __attribute__((availability(tvos, introduced=15.0))) __attribute__((availability(ios, introduced=15.0)));
		// // [Introduced (PlatformName.VisionOS, 1, 0)]
		// [TV (15,0), iOS (15,0)]
		// [Export ("setPreferredFrameRateRange:")]
		// void SetPreferredFrameRateRange (CAFrameRateRange preferredFrameRateRange);

		// -(void)playWithAnimationName:(NSString * _Nullable)animationName loop:(RiveLoop)loop direction:(RiveDirection)direction;
		[Export ("playWithAnimationName:loop:direction:")]
		void PlayWithAnimationName ([NullAllowed] string animationName, RiveLoop loop, RiveDirection direction);

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(void)reset;
		[Export ("reset")]
		void Reset ();

		// -(BOOL)configureModelWithArtboardName:(NSString * _Nullable)artboardName stateMachineName:(NSString * _Nullable)stateMachineName animationName:(NSString * _Nullable)animationName error:(NSError * _Nullable * _Nullable)error;
		[Export ("configureModelWithArtboardName:stateMachineName:animationName:error:")]
		bool ConfigureModelWithArtboardName ([NullAllowed] string artboardName, [NullAllowed] string stateMachineName, [NullAllowed] string animationName, [NullAllowed] out NSError error);

		// -(void)resetToDefaultModel;
		[Export ("resetToDefaultModel")]
		void ResetToDefaultModel ();

		// -(void)triggerInput:(NSString * _Nonnull)inputName;
		[Export ("triggerInput:")]
		void TriggerInput (string inputName);

		// -(void)setBooleanInput:(NSString * _Nonnull)inputName :(BOOL)value;
		[Export ("setBooleanInput::")]
		void SetBooleanInput (string inputName, bool value);

		// -(RiveSMIBool * _Nullable)boolInputWithNamed:(NSString * _Nonnull)name __attribute__((warn_unused_result("")));
		[Export ("boolInputWithNamed:")]
		[return: NullAllowed]
		RiveSMIBool BoolInputWithNamed (string name);

		// -(void)setFloatInput:(NSString * _Nonnull)inputName :(float)value;
		[Export ("setFloatInput::")]
		void SetFloatInput (string inputName, float value);

		// -(void)setDoubleInput:(NSString * _Nonnull)inputName :(double)value;
		[Export ("setDoubleInput::")]
		void SetDoubleInput (string inputName, double value);

		// -(RiveSMINumber * _Nullable)numberInputWithNamed:(NSString * _Nonnull)name __attribute__((warn_unused_result("")));
		[Export ("numberInputWithNamed:")]
		[return: NullAllowed]
		RiveSMINumber NumberInputWithNamed (string name);

		// -(void)triggerInput:(NSString * _Nonnull)inputName path:(NSString * _Nonnull)path;
		[Export ("triggerInput:path:")]
		void TriggerInput (string inputName, string path);

		// -(void)setBooleanInput:(NSString * _Nonnull)inputName value:(BOOL)value atPath:(NSString * _Nonnull)path;
		[Export ("setBooleanInput:value:atPath:")]
		void SetBooleanInput (string inputName, bool value, string path);

		// -(void)setFloatInput:(NSString * _Nonnull)inputName value:(float)value atPath:(NSString * _Nonnull)path;
		[Export ("setFloatInput:value:atPath:")]
		void SetFloatInput (string inputName, float value, string path);

		// -(void)setDoubleInput:(NSString * _Nonnull)inputName value:(double)value atPath:(NSString * _Nonnull)path;
		[Export ("setDoubleInput:value:atPath:")]
		void SetDoubleInput (string inputName, double value, string path);

		// -(NSString * _Nullable)getTextRunValue:(NSString * _Nonnull)textRunName __attribute__((warn_unused_result("")));
		[Export ("getTextRunValue:")]
		[return: NullAllowed]
		string GetTextRunValue (string textRunName);

		// -(NSString * _Nullable)getTextRunValue:(NSString * _Nonnull)textRunName path:(NSString * _Nonnull)path __attribute__((warn_unused_result("")));
		[Export ("getTextRunValue:path:")]
		[return: NullAllowed]
		string GetTextRunValue (string textRunName, string path);

		// -(BOOL)setTextRunValue:(NSString * _Nonnull)textRunName textValue:(NSString * _Nonnull)textValue error:(NSError * _Nullable * _Nullable)error;
		[Export ("setTextRunValue:textValue:error:")]
		bool SetTextRunValue (string textRunName, string textValue, [NullAllowed] out NSError error);

		// -(BOOL)setTextRunValue:(NSString * _Nonnull)textRunName path:(NSString * _Nonnull)path textValue:(NSString * _Nonnull)textValue error:(NSError * _Nullable * _Nullable)error;
		[Export ("setTextRunValue:path:textValue:error:")]
		bool SetTextRunValue (string textRunName, string path, string textValue, [NullAllowed] out NSError error);

		// -(NSArray<NSString *> * _Nonnull)artboardNames __attribute__((warn_unused_result("")));
		[Export ("artboardNames")]
		// [Verify (MethodToProperty)]
		string[] ArtboardNames { get; }

		// -(RiveView * _Nonnull)createRiveView __attribute__((warn_unused_result("")));
		[Export ("createRiveView")]
		// [Verify (MethodToProperty)]
		RiveView CreateRiveView { get; }

		// -(void)setRiveView:(RiveView * _Nonnull)view;
		[Export ("setRiveView:")]
		void SetRiveView (RiveView view);

		// -(void)updateWithView:(RiveView * _Nonnull)view;
		[Export ("updateWithView:")]
		void UpdateWithView (RiveView view);

		// -(void)deregisterView;
		[Export ("deregisterView")]
		void DeregisterView ();

		// -(void)setView:(RiveView * _Nonnull)view;
		[Export ("setView:")]
		void SetView (RiveView view);

		// -(BOOL)riveFileDidLoad:(RiveFile * _Nonnull)riveFile error:(NSError * _Nullable * _Nullable)error;
		[Export ("riveFileDidLoad:error:")]
		bool RiveFileDidLoad (RiveFile riveFile, [NullAllowed] out NSError error);

		// -(void)riveFileDidError:(NSError * _Nonnull)error;
		[Export ("riveFileDidError:")]
		void RiveFileDidError (NSError error);

		// -(void)playerWithPlayedWithModel:(RiveModel * _Nullable)riveModel;
		[Export ("playerWithPlayedWithModel:")]
		void PlayerWithPlayedWithModel ([NullAllowed] RiveModel riveModel);

		// -(void)playerWithPausedWithModel:(RiveModel * _Nullable)riveModel;
		[Export ("playerWithPausedWithModel:")]
		void PlayerWithPausedWithModel ([NullAllowed] RiveModel riveModel);

		// -(void)playerWithLoopedWithModel:(RiveModel * _Nullable)riveModel type:(NSInteger)type;
		[Export ("playerWithLoopedWithModel:type:")]
		void PlayerWithLoopedWithModel ([NullAllowed] RiveModel riveModel, nint type);

		// -(void)playerWithStoppedWithModel:(RiveModel * _Nullable)riveModel;
		[Export ("playerWithStoppedWithModel:")]
		void PlayerWithStoppedWithModel ([NullAllowed] RiveModel riveModel);

		// -(void)playerWithDidAdvanceby:(double)seconds riveModel:(RiveModel * _Nullable)riveModel;
		[Export ("playerWithDidAdvanceby:riveModel:")]
		void PlayerWithDidAdvanceby (double seconds, [NullAllowed] RiveModel riveModel);
	}

	// @protocol RiveWeightProvider
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP11RiveRuntime18RiveWeightProvider_")]
	// [Protocol]
	interface RiveWeightProvider
	{
		// @required @property (readonly, nonatomic) NSInteger riveWeightValue;
		[Abstract]
		[Export ("riveWeightValue")]
		nint RiveWeightValue { get; }
	}

	// @interface StateMachineInput : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC11RiveRuntime17StateMachineInput")]
	[DisableDefaultCtor]
	interface StateMachineInput
	{
	}

	// @interface RiveRuntime_Swift_943 (UIFont) <RiveFontWidthProvider>
	[Category]
	[BaseType (typeof(UIFont))]
	interface UIFont_RiveRuntime_Swift_943
	{
		// @property (readonly, nonatomic) NSInteger riveFontWidthValue;
		[Export ("riveFontWidthValue")]
		// nint RiveFontWidthValue { get; }
		nint GetRiveFontWidthValue (UIFont self);
	}

	// @interface RiveRuntime_Swift_948 (UIFont) <RiveWeightProvider>
	[Category]
	[BaseType (typeof(UIFont))]
	interface UIFont_RiveRuntime_Swift_948
	{
		// @property (readonly, nonatomic) NSInteger riveWeightValue;
		[Export ("riveWeightValue")]
		// nint RiveWeightValue { get; }
		nint GetRiveWeightValue (UIFont self);
	}

	// @interface RiveRuntime_Swift_953 (UIFont) <RiveFallbackFontProvider>
	[Category]
	[BaseType (typeof(UIFont))]
	interface UIFont_RiveRuntime_Swift_953
	{
		// @property (readonly, nonatomic, strong) UIFont * _Nonnull fallbackFont;
		[Export ("fallbackFont", ArgumentSemantic.Strong)]
		// UIFont FallbackFont { get; }
		UIFont GetFallbackFont (UIFont self);
	}
}
