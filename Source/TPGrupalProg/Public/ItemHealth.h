// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Item.h"
#include "ItemHealth.generated.h"

/**
 * 
 */
UCLASS()
class TPGRUPALPROG_API AItemHealth : public AItem
{
	GENERATED_BODY()


public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	int HealthPoints = 10;

	virtual void NotifyActorBeginOverlap(AActor* OtherActor) override;
};
