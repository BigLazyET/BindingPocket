#!/bin/bash

sharpie -v

SDK_VER=$(xcrun --sdk iphoneos --show-sdk-version)
FRAMEWORK="RiveRuntime.xcframework/ios-arm64/RiveRuntime.framework"

sharpie bind \
--sdk=iphoneos${SDK_VER} \
--framework "$FRAMEWORK" \
--namespace RiveRuntime.iOS \
-o ../../Sharpie/RiveRuntime.iOS