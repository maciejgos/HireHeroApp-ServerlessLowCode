# Shared Library

## Accepted

What is the status, such as proposed, accepted, rejected, deprecated, superseded, etc.?

## Context

To simplify implementation I would like to use single shared library with common models and API.
It will contain:
- models
- API interface
- Request service which is a facade to call REST API

## Decision

Move all models to shared lib and create single Refit API interface.

## Consequences

It will be easier to share common parts between seperated front office and back office Blazor Webassembly apps.