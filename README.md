# Mutable Variable Swap Bug in F#

This repository demonstrates a common error in F# involving mutable variables and their unexpected behavior when passed to functions.  The `swap` function intends to swap the values of two mutable variables, but due to how F# handles mutable variables passed to functions by value, the swap doesn't persist outside of the `swap` function.

## The Problem

The issue arises from the fact that the `swap` function receives copies of `x` and `y`, not direct references. Therefore, any modifications made within `swap` are applied only to these copies, leaving the original `x` and `y` unchanged.

## Solution

To address this, we can leverage tuples to return modified values and explicitly assign them back to `x` and `y`, or refactor to use byref if appropriate. The provided solution uses tuples for clarity.