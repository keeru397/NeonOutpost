
# Git Workflow - Neon Outpost

## Chosen Model
Feature Branching

## Branch Structure
- main: Production-ready branch.
- develop: Integration branch.
- feature/*: Individual feature development.
- hotfix/*: Urgent production bug fixes.

## Merge Rules
1. Every feature is developed in a separate branch.
2. Developers create Pull Requests into develop.
3. At least one team member reviews each PR.
4. CI builds and tests must pass before merging.
5. Use non-fast-forward merges to preserve history.
6. No direct pushes to main.

## Commit Naming Conventions
- feat: New features
- fix: Bug fixes
- chore: Maintenance work
- docs: Documentation changes
- ci: CI/CD configuration

## Development Process
1. Create a feature branch from develop.
2. Implement and test the feature.
3. Commit and push the changes.
4. Open a Pull Request.
5. Obtain approval and passing CI checks.
6. Merge into develop.
