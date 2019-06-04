clear all
clc
seed=1;
retest7=zeros(20,684);
amp_arr=0.8*rand(20,1)+0.3;
t6_arr=30*rand(20,1)+3;
period_arr=randi([40,200],20,1);
seed_arr=randi([1,1000],20,1);
for i=1:20
    amp7=amp_arr(i,1);
    t6=t6_arr(i,1);
    period=period_arr(i,1);
    seed=seed_arr(i,1);
    sim("testc6.slx"); 
    for j=1:684
        if yc7(j)<0
            yc7(j)=0;
        elseif yc7(j)>4
                yc7(j)=4;
        end
    end
    retest7(i,:)=yc7;
end

stairs(tout,retest7')
save retest7.mat retest7;