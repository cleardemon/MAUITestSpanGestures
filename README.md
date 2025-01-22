# MAUI TestSpanGestures

This is a test app to identify an issue with gesture recognisers when used in a `Span`, contained inside a `CollectionView`. 

On iOS, when tapping on a `Span` inside an item on the `CollectionView`, nothing happens. On Android, the tap is recognised.

# Testing

Instructions for setting up an environment are outside the scope of this document. See https://learn.microsoft.com/en-us/dotnet/maui/

On a suitable Mac, running the latest version of .NET 8 and MAUI 8.0.100 workflows, clone this repository, and open this solution in VSCode or Rider. Simply run it against the iOS Simulator and an Android Emulator that has been set up on your machine.


## iOS Testing
1. Navigate to the SpanInView tab. Click on the blue underlined link. It will prompt.
2. Navigate to the SpanInCollectionView tab. Click on `Item 0` in the list. No prompt.
3. Scroll the list down to the bottom.
4. Scroll the list back to the top.
5. Click on `Item 0`. It will prompt.

## Android Testing

1. Navigate to the SpanInView tab. Click on the link. It will prompt.
2. Navigate to the SpanInCollectionView. Click on `Item 0`. It will prompt.

## Conclusion

Android is behaving correctly. iOS seems to have some strange behaviour.

# Difference between `SpanInCollectionView` and `SpanInView`

`SpanInView` uses a `FormattedString` inside a `Label`, as part of a normal page layout. It does not use a container (or list) to display its controls. This works as expected on both platforms.

`SpanInCollectionView` does the same thing, except it is using a `CollectionView` and each item is bound using a `DataTemplate`. 

# Video demo

https://github.com/user-attachments/assets/71ca5574-55d6-45c0-8038-5d6aa3c35984

